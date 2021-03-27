using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if( _context.Departament.Any() ||
                _context.SalesRecord.Any() ||
                _context.Seller.Any())
            {
                return; // DB has been seeded
            }

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Eletronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Books");
            Departament d5 = new Departament {Id = 5, Name = "Course" };

            Seller s1 = new Seller(1, "Willian", "willian@gmail.com", new DateTime(1990,5,08), 5000.0, d2);
            Seller s2 = new Seller(2, "Pedro", "pedro@gmail.com", new DateTime(1992, 9, 20), 5000.0, d1);
            Seller s3 = new Seller(3, "Maria", "maria@gmail.com", new DateTime(1993, 7, 18), 5000.0, d3);
            Seller s4 = new Seller(4, "Joana", "joana@gmail.com", new DateTime(1994, 6, 28), 5000.0, d4);
            Seller s5 = new Seller(5, "Ana", "ana@gmail.com", new DateTime(1995, 4, 01), 5000.0, d5);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2020, 12, 25), 10520.05, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2020, 12, 22), 10520.05, SaleStatus.Billed, s4);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2020, 12, 23), 10520.05, SaleStatus.Billed, s5);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2020, 12, 24), 10520.05, SaleStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2020, 12, 25), 10520.05, SaleStatus.Billed, s2);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2020, 12, 26), 10520.05, SaleStatus.Billed, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2020, 12, 27), 10520.05, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2020, 12, 28), 10520.05, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2020, 12, 29), 10520.05, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2020, 12, 22), 10520.05, SaleStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2020, 12, 23), 10520.05, SaleStatus.Billed, s3);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2020, 12, 24), 10520.05, SaleStatus.Billed, s5);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2020, 12, 25), 10520.05, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2020, 12, 26), 10520.05, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2020, 12, 27), 10520.05, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2020, 12, 28), 10520.05, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2020, 12, 29), 10520.05, SaleStatus.Billed, s4);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2020, 12, 1), 10520.05, SaleStatus.Billed, s5);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2020, 12, 2), 10520.05, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2020, 12, 2), 10520.05, SaleStatus.Billed, s4);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2020, 12, 2), 10520.05, SaleStatus.Billed, s3);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2020, 12, 22), 10520.05, SaleStatus.Billed, s2);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2020, 12, 23), 10520.05, SaleStatus.Billed, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2020, 12, 24), 10520.05, SaleStatus.Billed, s1);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2020, 12, 25), 10520.05, SaleStatus.Billed, s1);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2020, 12, 26), 10520.05, SaleStatus.Billed, s1);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2020, 12, 27), 10520.05, SaleStatus.Billed, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2020, 12, 28), 10520.05, SaleStatus.Billed, s1);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2020, 12, 29), 10520.05, SaleStatus.Billed, s1);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2020, 12, 1), 10520.05, SaleStatus.Billed, s1);

            _context.Departament.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19
            , r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
