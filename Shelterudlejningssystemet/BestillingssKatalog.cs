using Shelterudlejningssystemet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelterudlejningssystemet
{
     public class BestillingsKatalog
    {
        private List<FdfKreds> Fdfkreds; 
        
        //constructor der sætter listen igang 
        public BestillingsKatalog()
        { 
            Fdfkreds = new List<FdfKreds>();
        }

        //tilføje fdfkreds til listen
        public void TilføjFdfKreds(FdfKreds fdfKreds)
        {
            fdfKreds.Add(fdfKreds: fdfKreds);
        }
        public List <FdfKreds> GetFdfKreds()
        {
            return Fdfkreds;
        }
        //printkataloget
        public void PrintKataloget()
        {
            Console.WriteLine(Fdfkreds);
        }

    }

}





