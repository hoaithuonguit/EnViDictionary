using Dictionary.DictionaryDA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Class
{
    public class Verbs
    {
        /// <summary>
        /// GetAllVerbs 
        /// todo show irregular verbs
        /// </summary>
        /// <returns></returns>
        public List<Verb> GetAllVerbs()
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.Verbs
                              select a
                             ).ToList();
                return result;
            }
        }

        /// <summary>
        /// SearchVerbs in irregular verbs 
        /// </summary>
        /// <param name="inWords"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public List<Verb> SearchVerbs(string inWords, int key)
        {
            using (var context = new EnViEntities1())
            {
               
                if (key == 1) //search first
                {
                    var result = (from a in context.Verbs
                                  where a.First == inWords
                                  select a).ToList<Verb>();
                    return result;
                }
                else 
                    if (key == 2) //search second
                {
                    var result = (from a in context.Verbs
                                  where a.Second == inWords
                                  select a).ToList<Verb>();
                    return result;
                }
                else 
                    if (key == 3) // search thirst
                {
                    var result = (from a in context.Verbs
                                  where a.Thirst == inWords
                                  select a).ToList<Verb>();
                    return result;
                }
                else // search default (all)
                {
                    var result = (from a in context.Verbs
                                  where a.Thirst == inWords || a.First == inWords || a.Second == inWords
                                  select a
                                 ).ToList<Verb>();
                    return result;
                }

            }
        }



    }
}
