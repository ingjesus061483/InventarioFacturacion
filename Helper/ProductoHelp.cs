using DataAccess;
using Helper.DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helper
{
    public class ProductoHelp:IHelp<ProductoDTO >
    {
        readonly InventarioDbContext _context;
        public ProductoHelp(InventarioDbContext context)
        {
            _context = context;
        }
        public IQueryable<ProductoDTO> Queryable 
        {
            get
            {
                return (from pro in _context.Productos
                                    join cat in _context.Categorias on pro.CategoriaId equals cat.Id
                                    join unid in _context.UnidadMedidas on pro.UnidadMedidaId equals unid.Id
                                    select new ProductoDTO
                                    {
                                       Id = pro.Id,
                                       Codigo= pro.Codigo,
                                        Nombre =  pro.Nombre,
                                        Costo = pro.Costo,
                                        Precio = pro.Precio,
                                        Existencias=_context .Existencias .Where(x=>x.ProductoId==pro.Id ).ToList(),
                                        RutaImagen = pro.RutaImagen,
                                        Descripcion = pro.Descripcion,
                                        CategoriaId = pro.CategoriaId,
                                        Categoria = cat,
                                        UnidadMedidaId = pro.UnidadMedidaId,
                                        UnidadMedida = unid
                                    });
            }
        }
        public Producto BuscarProducto(string codigo)
        {
            var producto = Queryable.Where(x=> x.Codigo ==codigo ).AsEnumerable().Select(x=>new Producto
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Nombre = x.Nombre,
                Costo = x.Costo,
                Precio = x.Precio,
                Existencias = x.Existencias ,
                RutaImagen = x.RutaImagen,
                Descripcion = x.Descripcion,
                CategoriaId = x.CategoriaId,
                Categoria =x. Categoria,
                UnidadMedidaId = x.UnidadMedidaId,
                UnidadMedida =x.UnidadMedida
            }). FirstOrDefault ();
            return producto;
        }
        public Producto BuscarProducto(int id)
        {
            var producto = Queryable.Where(x => x.Id  == id).AsEnumerable().Select(x => new Producto
            {
                Id = x.Id,
                Codigo = x.Codigo,
                Nombre = x.Nombre,
                Costo = x.Costo,
                Precio = x.Precio,
                Existencias = x.Existencias,
                RutaImagen = x.RutaImagen,
                Descripcion = x.Descripcion,
                CategoriaId = x.CategoriaId,
                Categoria = x.Categoria,
                UnidadMedidaId = x.UnidadMedidaId,
                UnidadMedida = x.UnidadMedida
            }).FirstOrDefault();
            return producto;

        }
        public void Guardar(ProductoDTO productoDTO)
        {
            if (!Validar(productoDTO))
            {
                return;
            }
            Producto producto = new Producto {
                Codigo =productoDTO.Codigo ,
                RutaImagen = productoDTO.RutaImagen ,
            CategoriaId = productoDTO.CategoriaId,
            UnidadMedidaId = productoDTO.UnidadMedidaId,
            Costo = productoDTO.Costo,
            Precio = productoDTO .Precio,
            Nombre = productoDTO .Nombre,
            Descripcion = productoDTO .Descripcion,
        };
            _context.Productos.Add(producto);
            _context.SaveChanges();
            Utilities .GetDialogResult ("El producto ha sido guardado", "",
           MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void Actualizar(int id ,ProductoDTO  prod)
        {
            if (!Validar(prod))
            {
                return;
            }
            var producto = BuscarProducto(id);

            producto.RutaImagen =prod. RutaImagen ;
            producto.CategoriaId = prod.CategoriaId;
            producto.UnidadMedidaId = prod.UnidadMedidaId;
            producto.Costo = prod.Costo;
            producto.Precio =prod.Precio;
            producto.Nombre = prod.Nombre ;
            producto.Descripcion = prod.Descripcion;            
            _context.SaveChanges();
            MessageBox.Show("El producto ha sido actualizado", "",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Eliminar(int id)
        {
            var producto = BuscarProducto(id);
            _context.Productos.Remove(producto);
            _context.SaveChanges();
        }
        public bool Validar(ProductoDTO producto)
        {
            if (string.IsNullOrEmpty(producto . Codigo))
            {
                Utilities .GetDialogResult ("El campo codigo no puede ser vacio", "",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (string.IsNullOrEmpty(producto.Nombre))
            {
                Utilities.GetDialogResult("El campo nombre no puede ser vacio", "",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (producto .Costo == 0)
            {
                Utilities.GetDialogResult("El campo costo  no puede ser vacio ni contener letras", "",
              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (producto . Precio == 0)
            {
                Utilities.GetDialogResult("El campo precio no puede ser vacio ni contener letras", "",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (producto . CategoriaId == -1)
            {
                Utilities.GetDialogResult("El campo categoria no puede ser vacio", "",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false ;
            }
            if (producto . UnidadMedidaId == -1)
            {
                Utilities.GetDialogResult("El campo unida medida no puede ser vacio", "",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false;
            }
            return true; 
        }     
    }
}
