namespace Repository_Ornek
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tablo2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idT2 { get; set; }

        [StringLength(20)]
        public string var1 { get; set; }

        [StringLength(20)]
        public string var2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? var3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? var4 { get; set; }
    }


    public partial class tablo2Repository : Irepository<tablo2>
    {
        Model1 _context = new Model1();

        public IEnumerable<tablo2> List { get { return _context.tablo2; } }
        public void ADD(tablo2 entity)
        {
            _context.tablo2.Add(entity);
            _context.SaveChanges();
        }
        public void DELETE(tablo2 entity)
        {
            var old = _context.tablo2.Where(z => z.idT2 == entity.idT2).First();
            _context.tablo2.Remove(old);
            _context.SaveChanges();
        }
        public void UPDATE(tablo2 entity)
        {
            var old = _context.tablo2.Where(z => z.idT2 == entity.idT2).First();
            _context.Entry(old).State = System.Data.Entity.EntityState.Detached;
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
