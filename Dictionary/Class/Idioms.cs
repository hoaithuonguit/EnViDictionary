using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary.DictionaryBL.Idioms;
using Dictionary.DictionaryDA;

namespace Dictionary.Class
{
    public class Idioms
    {
        public int[] arrRandom = new int[10];
        /// <summary>
        /// GetAllIdiormInDatabase
        /// </summary>
        /// <returns></returns>
        public List<Idiorm> GetAllIdiormInDatabase()
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.idioms
                              select new Idiorm()
                              {
                                  ID = a.ID,
                                  EnWord = a.EnWord,
                                  ViWord = a.ViWord
                              }).ToList();
                return result;
            }
        }

        public int Dem()
        {
            using (var context = new EnViEntities1())
            {
                int result = (from a in context.idioms
                              select a).Count();
                return result;
            }
        }

        public List<Idiorm> GetDataIdiorm()
        {
            for (int i = 0; i < 10; i++) arrRandom[i] = -1;
            List<Idiorm> result = new List<Idiorm>();
            for (int i = 0; i < 10; i++)
            {
                result.Add(GetDataIdoirmWithID(i));

            }

            return result;
        }

        public bool CheckExist(int i)
        {
            for (int j = 0; j < 10; j++)
                if (arrRandom[j] == i) return false; return true;
        }
        public  Idiorm GetDataIdoirmWithID(int k)
        {
            Random ran = new Random();
            int i = ran.Next(0, Dem());
            while (!CheckExist(i))
                i = ran.Next(0, Dem());
            arrRandom[k] = i;
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.idioms
                              where a.ID == i
                                    
                              select new Idiorm()
                              {
                                  ID = a.ID,
                                  EnWord = a.EnWord, 
                                  ViWord = a.ViWord                               
                              }).FirstOrDefault();
                return result;
            }

        }
    }
}
