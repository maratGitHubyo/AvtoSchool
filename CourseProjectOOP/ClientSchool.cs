using System;

namespace CourseProjectOOP
{
    public class ClientSchool
    {
        private String FIO;
        private String category;
        private int countHourse;
        private int countFails;
        private bool resultExam;
        private bool completedTraining;

        public ClientSchool(string fio, string category, int countHourse, int countFails, bool resultExam, bool completedTraining)
        {
            FIO = fio;
            this.category = category;
            this.countHourse = countHourse;
            this.countFails = countFails;
            this.resultExam = resultExam;   
            this.completedTraining = completedTraining;
        }

        public String getFIO()
        {
            return FIO; 
        }
        
        public String getCategory()
        {
            return category; 
        }
        
        public int getCountHourse()
        {
            return countHourse; 
        }
        
        public int getCountFails()
        {
            return countFails; 
        }

        public bool getResultExam()
        {
            return resultExam;
        }

        public bool getCompletedTraining()
        {
            return completedTraining; 
        }
        
        
        
        
        public void setFIO(String fio)
        {
            this.FIO = fio;
        }
        
        public void setCategory(String c)
        {
            this.category = c;
        }
        
        public void setCountHourse(int h)
        {
            this.countHourse = h;
        }
        
        public void setCountFails(int f)
        {
            this.countFails = f;
        }

        public void setResultExam(bool r)
        {
            this.resultExam = r;
        }

        public void setCompletedTraining(bool t)
        {
            this.completedTraining = t;
        }
       
        public override bool Equals(object c)
        {
            ClientSchool obj = (ClientSchool) c;
            return this.FIO.Equals(obj.getFIO());
        }

        public override string ToString()
        {
            return FIO + "," + category + "," + countHourse.ToString() + "," + countFails.ToString() + "," +
                   resultExam.ToString() + "," + completedTraining.ToString();
        }
    }
}