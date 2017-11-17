using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace How_become_milioner
{
    class SerializerStringText:ISerializer
    {
        public void Save(ICollection<Question> collection)
        {

        }
        public ICollection<Question> Load()
        {
            bool ferst=true;
            bool truh = false;
            float size = 0f;

            StreamReader sr = new StreamReader("../../Resurses/question.txt", Encoding.Default);
            string line;

            List<Question> tempL=new List<Question>();
            Question tempT=new Question();

            while ((line = sr.ReadLine()) != null)
            {
                if (line.IndexOf("?") == line.Length-1 && ferst)
                {
                    ferst = false;
                    truh = true;
                    tempT.Questio += line;
                }
                else if (!truh)
                {
                    tempT.Questio += line;
                }
                else if (truh && size == 0f)
                {
                    tempT.Answer_1 = line;
                    size++;
                }
                else if (truh && size == 1f)
                {
                    tempT.Answer_2 = line;
                    size++;
                }
                else if (truh && size == 2f)
                {
                    tempT.Answer_3 = line;
                    size++;
                }
                else if (truh && size == 3f)
                {
                    tempT.Answer_4 = line;
                    tempL.Add(tempT);
                    tempT = new Question();

                    size = 0;
                    ferst = true;
                    truh = false;
                }
            }
            sr.Close();
        
            return tempL;
        }
    }
}
