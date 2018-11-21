using ComboBoxExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxExample.Storage
{
    public static class TestData
    {
        public static List<Continent> GetContinents()
        {
            return new List<Continent>
            {
                new Continent {
                    Name ="Europe",
                    Countries = new List<Country>
                    {
                        new Country { Name="Germany" },
                        new Country { Name="Denmark" },
                        new Country { Name="France" }
                    }
                },
                new Continent
                {
                    Name = "North America",
                    Countries = new List<Country>
                    {
                        new Country { Name="Canada" },
                        new Country { Name="USA" },
                        new Country { Name="Mexico" }
                    }
                },
                new Continent
                {
                    Name = "Africa",
                    Countries = new List<Country>
                    {
                        new Country { Name="Nigria" },
                        new Country { Name="Congo" },
                        new Country { Name="Marocco" }
                    }
                }
            };
        }
    }
}
