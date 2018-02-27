using System;
using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class Product
    {
        //Data anotations []
        [Key]
        public int IdProduct        { get; set; }
        public string Description   { get; set; }
        public decimal Price        { get; set; }        
        public float Stock          { get; set; }
        public DateTime LastBuy     { get; set; }    
        public String Remarks       { get; set; }
    }
}


/* Agregar Cambios a la base de datos (evita estar borrando la DB en cada cambio)
 * NOTA: solo hace los cambios a la DB, Manualmente hay que modificar la vista y controlador
 * -> go to tools / Nuget Manager / consola
 * -> type to enable the Migrations:
 *      enable-Migrations -ContextTypeName nombreDelContext 
 *      (ej: enable-Migrations -ContextTypeName storeContext)
 *  
 *  ->al agregar algun cambio(campos a la db) al proyecto
 *  type:
 *      Add-Migration commentario 
 *      (ej: Add-Migration AddRemarksFieldtoDB)
 *      
 * -> Finalmente para aplicar los cambios
 *      Update-Database
 */
