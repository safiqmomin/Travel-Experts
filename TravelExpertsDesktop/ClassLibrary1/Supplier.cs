using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
 * Author : Sneha Padel (000783907)
 * Date : 19th July, 2018
 * Purpose: sets properties for the supplier table 
 ***************************************************************/
namespace TravelExpertsLibrary
{
    // Business(Entity) Class for Supplier - Middle layer
    public class Supplier
    {
        public Supplier() { }

        public int SupplierId { get; set; }

        public string SupName { get; set; }
    }
}
