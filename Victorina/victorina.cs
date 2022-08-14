using System;
using System.IO;
using System.Collections.Generic;

namespace Victorina
{
    class victorina
    {
        public victorina()
        {
            his_ = new List<HistoryQuestions>();
            arrQuest = File.ReadAllLines(@"HisQuestins.txt");
            result = new Result();
            results = new TableResults();


            for (int i = 0; i < arrQuest.Length; i++)
            {
                string[] splAtring = arrQuest[i].Split(".");
                qHis_ = new HistoryQuestions();
                qHis_.SetQuestions(splAtring[0]);
                qHis_.SetTrueAnswer(splAtring[1]);
                qHis_.SetAnswers(splAtring[2], splAtring[3], splAtring[4], splAtring[5]);
                his_.Add(qHis_);
            }

            geo_ = new List<GeoQuestions>();
            arrQuest = File.ReadAllLines(@"GeoQuestins.txt");

            for (int i = 0; i < arrQuest.Length; i++)
            {
                string[] splAtring = arrQuest[i].Split(".");
                qGeo_ = new GeoQuestions();
                qGeo_.SetQuestions(splAtring[0]);
                qGeo_.SetTrueAnswer(splAtring[1]);
                qGeo_.SetAnswers(splAtring[2], splAtring[3], splAtring[4], splAtring[5]);
                geo_.Add(qGeo_);
            }

            bio_ = new List<BioQuestions>();
            arrQuest = File.ReadAllLines(@"BioQuestins.txt");

            for (int i = 0; i < arrQuest.Length; i++)
            {
                string[] splAtring = arrQuest[i].Split(".");
                qBio_ = new BioQuestions();
                qBio_.SetQuestions(splAtring[0]);
                qBio_.SetTrueAnswer(splAtring[1]);
                qBio_.SetAnswers(splAtring[2], splAtring[3], splAtring[4], splAtring[5]);
                bio_.Add(qBio_);
            }

            count_ = 0;
        }

        public void Menu()
        {
            Console.WriteLine("\nМеню\n");
            Console.WriteLine("1. История");
            Console.WriteLine("2. География");
            Console.WriteLine("3. Биология");
            Console.WriteLine("4. Все");
        }
        public void Play()
        {
            Menu();
            userChoise = Console.ReadLine();

            if (userChoise == "1")
            {
                foreach (var q in his_)
                {
                    Console.WriteLine(q.GetQuestions());
                    foreach (var a in q.GetAnswers())
                    {
                        Console.WriteLine(a);
                    }
                    userChoise = Console.ReadLine();
                    if (q.GetTrueAnswer() == userChoise)
                    {
                        Console.WriteLine("Ответ правильный");
                        count_++;
                    }
                }

            }
            else if (userChoise == "2")
            {
                foreach (var q in geo_)
                {
                    Console.WriteLine(q.GetQuestions());
                    foreach (var a in q.GetAnswers())
                    {
                        Console.WriteLine(a);
                    }
                    userChoise = Console.ReadLine();
                    if (q.GetTrueAnswer() == userChoise)
                    {
                        Console.WriteLine("Ответ правильный");
                        count_++;
                    }
                }
            }
            else if (userChoise == "3")
            {
                foreach (var q in bio_)
                {
                    Console.WriteLine(q.GetQuestions());
                    foreach (var a in q.GetAnswers())
                    {
                        Console.WriteLine(a);
                    }
                    userChoise = Console.ReadLine();
                    if (q.GetTrueAnswer() == userChoise)
                    {
                        Console.WriteLine("Ответ правильный");
                        count_++;
                    }
                }
            }
            else if (userChoise == "4") 
            {
                for (int i = 0; i < 20; i++)
                {
                    randType = rand.Next(1, 3);
                    if (randType == 1)
                    {
                        randNum = rand.Next(0, 19);

                        his_[randNum].GetQuestions();
                        foreach (var a in his_[randNum].GetAnswers())
                        {
                            Console.WriteLine(a);
                        }
                        userChoise = Console.ReadLine();
                        if (his_[randNum].GetTrueAnswer() == userChoise)
                        {
                            Console.WriteLine("Ответ правильный");
                            count_++;
                        }
                    }
                    else if (randType == 2)
                    {
                        randNum = rand.Next(0, 19);

                        geo_[randNum].GetQuestions();
                        foreach (var a in geo_[randNum].GetAnswers())
                        {
                            Console.WriteLine(a);
                        }
                        userChoise = Console.ReadLine();
                        if (geo_[randNum].GetTrueAnswer() == userChoise)
                        {
                            Console.WriteLine("Ответ правильный");
                            count_++;
                        }
                    }
                    else if (randType == 3)
                    {
                        randNum = rand.Next(0, 19);

                        bio_[randNum].GetQuestions();
                        foreach (var a in bio_[randNum].GetAnswers())
                        {
                            Console.WriteLine(a);
                        }
                        userChoise = Console.ReadLine();
                        if (bio_[randNum].GetTrueAnswer() == userChoise)
                        {
                            Console.WriteLine("Ответ правильный");
                            count_++;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Не правильный выбор");
            }
        }
        public int GetCount()
        {
            return count_;
        }

        private string GetQuestion(List<HistoryQuestions> quest, int num)
        {
            return quest[num].GetQuestions();
        }
        private string GeoQuestion(List<GeoQuestions> quest, int num)
        {
            return quest[num].GetQuestions();
        }
        private string GeoQuestion(List<BioQuestions> quest, int num)
        {
            return quest[num].GetQuestions();
        }

        private List<string> GetAnswers(List<HistoryQuestions> quest, int num)
        {
            return quest[num].GetAnswers();
        }
        private List<string> GetAnswers(List<GeoQuestions> quest, int num)
        {
            return quest[num].GetAnswers();
        }
        private List<string> GetAnswers(List<BioQuestions> quest, int num)
        {
            return quest[num].GetAnswers();
        }

        private string GetTrueAnswer(List<HistoryQuestions> quest, int num)
        {
            return quest[num].GetTrueAnswer();
        }
        private string GetTrueAnswer(List<GeoQuestions> quest, int num)
        {
            return quest[num].GetTrueAnswer();
        }
        private string GetTrueAnswer(List<BioQuestions> quest, int num)
        {
            return quest[num].GetTrueAnswer();
        }

        private List<HistoryQuestions> his_;
        private List<GeoQuestions> geo_;
        private List<BioQuestions> bio_;

        private Result result;
        private TableResults results;

        private string[] arrQuest;

        private HistoryQuestions qHis_;
        private GeoQuestions qGeo_;
        private BioQuestions qBio_;

        private Random rand;
        private int randNum;
        private int randType;
        private string userChoise;
        private int count_;
    }
}
