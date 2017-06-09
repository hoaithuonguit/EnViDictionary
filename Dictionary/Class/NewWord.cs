using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary.DictionaryBL.Word;
using Dictionary.DictionaryBL.BaseWords;
using Dictionary.DictionaryDA;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Transactions;
using System.Collections;
using System.Data.Entity.Infrastructure;

namespace Dictionary.Class
{
    
    public class NewWord
    {
        public int[] arrRandom = new int[10] ;
        /// <summary>
        /// GetAllWordFromDatabase-- using for init Mainform
        /// </summary>
        /// <returns> ToList<Word> </returns>
        public List<Word> GetAllWordFromDatabase()
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.ENWORDs
                              select new Word()
                              {
                                  ID = a.ID,
                                  EnWord = a.EnWord1,
                                  ViWord = a.EnVi,
                                  Type = a.Type,
                                  Example = a.Example,
                                  Favorite = a.Favote,
                              }).ToList<Word>();
                return result;

            }
        }

        internal void DeleteRecent()
        {
            using (var context = new EnViEntities1())
            {
                var result = ((IObjectContextAdapter)context).ObjectContext;
                result.ExecuteStoreCommand("Delete from favorite");
            }
        }

        public List<string> Init()
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.ENWORDs
                              select
                                 a.EnWord1
                              ).ToList();
             
                return result;
            }
        }


     
      
        /// <summary>
        /// GetWordWhenSearch
        /// </summary>
        /// <param name="inKeyWords"></param>
        /// <returns> List of result search </returns>
        public Word GetWordWhenSearch(string inKeyWords)
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.ENWORDs
                              where a.EnWord1 == inKeyWords
                              select new Word()
                              {
                                  EnWord = a.EnWord1,
                                  ViWord = a.EnVi,
                                  Type = a.Type,
                                  Example = a.Example,
                                 
                              }).FirstOrDefault();
                if (result != null) return result;
                else return null;
            }
        }

        public void SetFavorite(string inWord)
        {
            using (var context = new EnViEntities1())
            {
                // update table EnWord!
                try
                {

                    // var a = context.ENWORDs.Single(p => p.EnWord1.Equals(inWord));
                    var result = (from a in context.ENWORDs
                             where a.EnWord1.Equals(inWord)
                             select a).FirstOrDefault();
                    result.Favote = 1;
                   // a.Favote = 1;
                    context.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //insert word to Favorite Table
                try
                {

                }
                catch (Exception e)
                { }

            }
        }

        /// <summary>
        /// InsertNewWords
        /// </summary>
        /// <param name="inID"></param>
        /// <param name="inEnWord"></param>
        /// <param name="inViWord"></param>
        /// <param name="inType"></param>
        /// <param name="inExample"></param>
        public void InsertNewWords(int inID, string inEnWord, string inViWord, string inType, string inExample)
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.ENWORDs
                              where a.EnWord1 == inEnWord
                              select a).ToList();
                if (result.Count() > 0) MessageBox.Show("this word is existed!");
                else
                {
                   
                    {
                        //try
                        {
                            ENWORD word = new ENWORD()
                            {
                                ID = inID,
                                EnWord1 = inEnWord,
                                EnVi = inViWord,
                                Type = inType,
                                Example = inExample,
                                Favote = 0
                            };
                            
                          
                            context.ENWORDs.Add(word);
                            context.Entry(word).State = EntityState.Added;
                           
                            
                            context.SaveChanges();
                          
                        }
                        //catch (Exception ex)
                        //{

                        //}
                    }
                }
            }
        }

        public int Dem()
        {
            using (var context = new EnViEntities1())
            {

                var s = (from a in context.ENWORDs
                         select a.ID).Max();
                      return s;
            }
              
        }


        public void InsertIntoFavorite (int inID, string inEnWord )
        {
            using (var context = new EnViEntities1())
            {
                if (CheckFavorite(inEnWord))
                {
                    Favorite word = new Favorite()
                    {
                        ID = inID,
                        EnWord = inEnWord
                    };
                    context.Favorites.Add(word);
                    context.Entry(word).State = EntityState.Added;
                    SetFavorite(inEnWord);
                    context.SaveChanges();  
                }

            }
        }

        public bool CheckFavorite(string inEnWord)
        {
            using (var context = new EnViEntities1())
            {
                var check = (from a in context.Favorites
                             where a.EnWord == inEnWord
                             select a).ToList();
                if (check.Count == 0) return true;
            }
                return false;
        }

       public List<string> GetFavoriteWord()
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.ENWORDs
                              where a.Favote == 1
                              select a.EnWord1).ToList();
                return result;
            }
        }

        public void XoaFavorite(string inWord)
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.ENWORDs
                              where a.EnWord1 == inWord 
                                    && a.Favote == 1
                              select a).First();
                result.Favote = 0;
                context.SaveChanges();
            }
        }

        public string GetTuRandom()
        {
            
            Random ran = new Random();
            int VT = ran.Next(0, Dem());
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.ENWORDs
                              where a.ID == VT
                              && a.EnWord1 != null
                              select a.EnWord1).First();
                return result;
            }
        }

        public List<BaseWord> GetDataWord()
        {
            //int[] id = new int[10];
            //for (int i=0; i< 10; i++)
            //{
            //    //int check = 0;
            //    //while (check == 0)
            //    //{
            //    //    Random ran = new Random();
            //    //    int k = ran.Next(0, Dem());

            //    //    for (int j = 0; j < i; j++)
            //    //    {
            //    //        if (k == id[j])
            //    //        {
            //    //            check = 1;
            //    //            break;
            //    //        }
            //    //    }
            //    //    if (check == 1) id[i] = k;
            //    //}
            //    Random ran = new Random();
            //    id[i] = ran.Next(0, Dem());
            //}
            for (int i = 0; i < 10; i++) arrRandom[i] = -1;
            List<BaseWord> result = new List<BaseWord>();
            for (int i = 0; i< 10; i++)
            {
                result.Add(GetDataWordWithID(i));
               
            }
            
            return result;
        }

        public BaseWord GetDataWordWithID(int k)
        {
            Random ran = new Random();
            int i = ran.Next(0, Dem());
            while (!CheckExist(i))
                i = ran.Next(0, Dem());
            arrRandom[k] = i;
            using (var context = new EnViEntities1())
            {
               var result = (from a in context.ENWORDs
                          where a.ID == i
                                && a.EnWord1 != null
                          select new BaseWord()
                          {
                              EnWord = a.EnWord1,
                              ViWord = a.EnVi
                          }).FirstOrDefault();
                return result;
            }
            
        }

        public bool CheckExist(int i)
        {
            for (int j = 0; j < 10; j++)
                if (arrRandom[j] == i ) return false; return true;
        }

        public void AddRecentWord(string inWords)
        {
            using (var context = new EnViEntities1())
            {
                Favorite word = new Favorite()
                {
                    ID = DemRecent() + 1,
                    EnWord = inWords                 
                };
                context.Favorites.Add(word);
                context.Entry(word).State = EntityState.Added;
                context.SaveChanges();

                //context.ENWORDs.Add(word);
                //context.Entry(word).State = EntityState.Added;


                //context.SaveChanges();
            }
        }

        public int DemRecent ()
        {
            using (var context = new EnViEntities1())
            {
                return (from a in context.Favorites
                        select a).Count();
            }
        }

        public List<string > GetRecent ()
        {
            using (var context = new EnViEntities1())
            {
                var result = (from a in context.Favorites
                              select a.EnWord).ToList();
                return result;
            }
        }
    }
}
