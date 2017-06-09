using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary.DictionaryBL;
using Dictionary.DictionaryDA;
using Dictionary.DictionaryBL.Structure;

namespace Dictionary.Class
{
    // class use for structure sentences
    public class structure
    {
        /// <summary>
        /// GetAllStructure -- init in Main
        /// </summary>
        /// <returns></returns>
        public List<Structure> GetAllStructure()
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.structure1
                              select new Structure()
                              {
                                  ID = a.ID,
                                  EnWord = a.EnWord,
                                  ViWord = a.EnVi,
                                  Example = a.Example,
                                  Key = a.Key
                              }
                            ).ToList<Structure>();
                return result;
            }
        }


        /// <summary>
        /// SearchStructure
        /// </summary>
        /// <param name="inKey"></param>
        /// <returns></returns>
        public List<Structure> SearchStructure( string inKey)
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.structure1
                              where a.Key == inKey
                              select new Structure()
                              {
                                  ID = a.ID,
                                  EnWord = a.EnWord,
                                  ViWord = a.EnVi,
                                  Example = a.Example,
                                  Key = a.Key
                              }).ToList<Structure>();
                return result;
            }
        }
    }
}
