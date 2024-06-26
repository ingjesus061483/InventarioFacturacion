﻿using DataAccess;
using Helper.View;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{
    public class EmailHelp
    {
        public string Remitente { get; set; }
        public string Pwd { get; set; }
        ClienteHelp _clienteHelp;
        ProveedorHelp _proveedorHelp;
        public EmailHelp (ProveedorHelp proveedorHelp ,ClienteHelp   clienteHelp)
        {
            _proveedorHelp  = proveedorHelp ;
            _clienteHelp = clienteHelp;
        }
        public IQueryable<PersonaView> Queryable
        {
            get
            {
                IEnumerable<PersonaView> proveedor = _proveedorHelp.Queryable.AsEnumerable().Select(x => new PersonaView
                {
                    Id = x.Id,
                    FechaNacimiento = x.FechaNacimiento,
                    TipoIdentificacionId = x.TipoIdentificacionId,
                    TipoIdentificacion = x.TipoIdentificacion.Nombre,
                    Identificacion = x.Identificacion,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    Email = x.Email,
                });
                IEnumerable<PersonaView> cliente = _clienteHelp.Queryable.AsEnumerable().Select(x => new PersonaView
                {
                    Id = x.Id,
                    FechaNacimiento = x.FechaNacimiento,
                    TipoIdentificacionId = x.TipoIdentificacionId,
                    TipoIdentificacion = x.TipoIdentificacion.Nombre,
                    Identificacion = x.Identificacion,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Direccion = x.Direccion,
                    Telefono = x.Telefono,
                    Email = x.Email,
                });
                return proveedor.Union(cliente).AsQueryable();
            }
        }

        MailAddress From
        {
            get
            {
                return new MailAddress(Remitente);
            }
        }
        SmtpClient Servidor
        {
            get
            {             
                NetworkCredential credenciales = new NetworkCredential(Remitente, Pwd);                
                return new SmtpClient(ConfigurationManager.AppSettings["Host"],
                                    int.Parse(ConfigurationManager.AppSettings["Puerto"]))
                {                  
                    Credentials = credenciales,                   
                    EnableSsl = true,
                };                
 
            }
        }
        public List<string >Adjuntar()
        {
            List<string> FileNames=null;
            OpenFileDialog openFileDialog = new OpenFileDialog { Multiselect = true };
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                FileNames = openFileDialog.FileNames.ToList();
            return FileNames;            
        }
        MailMessage GetMail(Array Destinatarios ,string body,string Subject)
        {
            MailMessage correo = new MailMessage { From = From, Body = body, Subject = Subject  };
            for (int i = 0; i <= Destinatarios.Length - 1; i++)
            {
                correo.To.Add(Destinatarios.GetValue(i).ToString());
            }
            return correo;
        }
        void GetAttachment(MailMessage mail,List<string >files)
        {
            if (files != null)
            {
                foreach (string dato in files)
                {
                    FileStream fs = File.Open(dato, FileMode.Open);
                    Attachment Datosadjuntos = new Attachment(fs, fs.Name);
                    mail.Attachments.Add(Datosadjuntos);
                }
            }

        }
        public void SendMail(Array Destinatarios, string asunto, string mensaje, List<string> datos)
        {
            try
            {
                MailMessage correo = GetMail(Destinatarios, mensaje, asunto);
                GetAttachment(correo, datos);
                Servidor.Send(correo);
                correo.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}