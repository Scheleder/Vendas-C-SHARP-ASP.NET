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
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // Database já está populado!
            }

            Department d1 = new Department(new int(), "Computers");
            Department d2 = new Department(new int(), "Electronics");
            Department d3 = new Department(new int(), "Fashion");
            Department d4 = new Department(new int(), "Books");

            Seller s1 = new Seller(new int(), "Bob Brown", "brown@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(new int(), "Maria Green", "green@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(new int(), "Alex Grey", "grey@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(new int(), "Martha Red", "red@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(new int(), "Donald Blue", "blue@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(new int(), "Alex Pink", "pink@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(new int(), new DateTime(2023, 01, 25), 3700.0, SaleStatus.Billed, s1, "Notebook Samsung");
            SalesRecord r2 = new SalesRecord(new int(), new DateTime(2023, 01, 4), 70.0, SaleStatus.Billed, s5, "Bermuda Jeans");
            SalesRecord r3 = new SalesRecord(new int(), new DateTime(2023, 01, 13), 40.0, SaleStatus.Cancelled, s4, "Arte da Guerra");
            SalesRecord r4 = new SalesRecord(new int(), new DateTime(2023, 01, 1), 8.0, SaleStatus.Billed, s1, "Mouse USB");
            SalesRecord r5 = new SalesRecord(new int(), new DateTime(2023, 01, 21), 3900.0, SaleStatus.Billed, s3, "Notebook Sony");
            SalesRecord r6 = new SalesRecord(new int(), new DateTime(2023, 01, 15), 3500.0, SaleStatus.Billed, s1, "Notebook Dell");
            SalesRecord r7 = new SalesRecord(new int(), new DateTime(2023, 01, 20), 13000.0, SaleStatus.Billed, s2, "TV Sony");
            SalesRecord r8 = new SalesRecord(new int(), new DateTime(2023, 01, 11), 12.0, SaleStatus.Billed, s4, "Viagem ao centro da Terra");
            SalesRecord r9 = new SalesRecord(new int(), new DateTime(2023, 01, 14), 5300.0, SaleStatus.Pending, s6, "TV Panasonic");
            SalesRecord r10 = new SalesRecord(new int(), new DateTime(2023, 01, 7), 9000.0, SaleStatus.Billed, s6, "TV Sony");
            SalesRecord r11 = new SalesRecord(new int(), new DateTime(2023, 01, 13), 2100.0, SaleStatus.Billed, s2, "Home Theater JBL");
            SalesRecord r12 = new SalesRecord(new int(), new DateTime(2023, 01, 25), 4300.0, SaleStatus.Pending, s3, "Notebook Dell");
            SalesRecord r13 = new SalesRecord(new int(), new DateTime(2023, 01, 21), 18.0, SaleStatus.Billed, s4, "Fundação");
            SalesRecord r14 = new SalesRecord(new int(), new DateTime(2023, 01, 4), 110.0, SaleStatus.Billed, s5, "Calça Levis");
            SalesRecord r15 = new SalesRecord(new int(), new DateTime(2023, 01, 12), 4200.0, SaleStatus.Billed, s1, "Notebook Dell");
            SalesRecord r16 = new SalesRecord(new int(), new DateTime(2023, 01, 5), 29.0, SaleStatus.Billed, s4, "Diário de um Mago");
            SalesRecord r17 = new SalesRecord(new int(), new DateTime(2023, 01, 1), 1200.0, SaleStatus.Billed, s1, "Impressora HP");
            SalesRecord r18 = new SalesRecord(new int(), new DateTime(2023, 01, 24), 4500.0, SaleStatus.Billed, s3, "Notebook Dell");
            SalesRecord r19 = new SalesRecord(new int(), new DateTime(2023, 01, 22), 7.0, SaleStatus.Billed, s5, "Meia Lupo");
            SalesRecord r20 = new SalesRecord(new int(), new DateTime(2023, 01, 15), 900.0, SaleStatus.Billed, s6, "TV Toshiba");
            SalesRecord r21 = new SalesRecord(new int(), new DateTime(2023, 01, 17), 2300.0, SaleStatus.Billed, s2, "TV Panasonic");
            SalesRecord r22 = new SalesRecord(new int(), new DateTime(2023, 01, 24), 26.0, SaleStatus.Billed, s4, "Meu pé de Laranja Lima");
            SalesRecord r23 = new SalesRecord(new int(), new DateTime(2023, 01, 19), 183.0, SaleStatus.Cancelled, s2, "Cafeteira");
            SalesRecord r24 = new SalesRecord(new int(), new DateTime(2023, 01, 12), 132.0, SaleStatus.Billed, s5, "Camisa Lacoste");
            SalesRecord r25 = new SalesRecord(new int(), new DateTime(2023, 01, 31), 430.0, SaleStatus.Billed, s3, "Monitor Philips");
            SalesRecord r26 = new SalesRecord(new int(), new DateTime(2023, 01, 6), 22.0, SaleStatus.Billed, s4, "O Alienista");
            SalesRecord r27 = new SalesRecord(new int(), new DateTime(2023, 01, 13), 3900.0, SaleStatus.Pending, s1, "Notebook Dell");
            SalesRecord r28 = new SalesRecord(new int(), new DateTime(2023, 01, 7), 78.0, SaleStatus.Billed, s3, "Teclado USB");
            SalesRecord r29 = new SalesRecord(new int(), new DateTime(2023, 01, 23), 120.0, SaleStatus.Billed, s5, "Camisa Lacoste");
            SalesRecord r30 = new SalesRecord(new int(), new DateTime(2023, 01, 12), 2300.0, SaleStatus.Billed, s2, "TV Panasonic");

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
