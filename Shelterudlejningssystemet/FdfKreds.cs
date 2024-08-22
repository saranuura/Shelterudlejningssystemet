using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelterudlejningssystemet
{
    public class FdfKreds
    {
        public string Name {get; set; }
        public int Aldersgruppe { get; set; }
        public int AntalDeltagere { get; set; }
        public int Id { get; set; }
        public int BookingDato { get; set; }
        public int BookingTidspunkt {get; set; }

        //constructor
        public FdfKreds(string name, int aldersgruppe, int antaldeltagere,int id, int bookingdato, int bookingtidspunkt)
        {
            Name = name;
            Aldersgruppe = aldersgruppe;
            AntalDeltagere = antaldeltagere;
            Id= id;
            BookingDato = bookingdato;
            BookingTidspunkt = bookingtidspunkt;
        }

        internal void Add(FdfKreds fdfKreds)
        {
            throw new NotImplementedException();
        }
    }
}
