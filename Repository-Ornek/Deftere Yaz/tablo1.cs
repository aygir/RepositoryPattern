namespace Repository_Ornek
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tablo1
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(20)]
        public string var1 { get; set; }

        [StringLength(20)]
        public string var2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? var3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? var4 { get; set; }
    }

    public partial class tablo1Repository : Irepository<tablo1>
    {
        Model1 _context = new Model1();

        public IEnumerable<tablo1> List { get { return _context.tablo1; } }
        public void ADD(tablo1 entity)
        {
            _context.tablo1.Add(entity);
            _context.SaveChanges();
        }
        public void DELETE(tablo1 entity)
        {
            var old = _context.tablo1.Where(z => z.id == entity.id).First();
            _context.tablo1.Remove(old);
            _context.SaveChanges();
        }
        public void UPDATE(tablo1 entity)
        {
            var old = _context.tablo1.Where(z => z.id == entity.id).First();
            _context.Entry(old).State = System.Data.Entity.EntityState.Detached;
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
