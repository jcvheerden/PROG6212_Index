using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDayCare_Icetask1
{
    public class Doggo
    {
        //Declaration
        int age, dogWeight, dogKennel;
        string dogBreed, dogName;


        public Doggo(int age, int dogWeight, int dogKennel, string dogBreed, string dogName)
        {
            this.age = age;
            this.dogWeight = dogWeight;
            this.dogBreed = dogBreed;
            this.dogName = dogName;
            this.dogKennel = dogKennel;
        }

        public object this[int index] //Number index
        {
            get
            {
                if (index == 0)
                    return this.age;
                else if (index == 1)
                    return this.dogWeight;
                else if (index == 2)
                    return this.dogBreed;
                else if (index == 3)
                    return this.dogName;
                else if (index == 4)
                    return this.dogKennel;
                return null;

            }

            set
            {

                if (index == 0)
                    this.age = (int)value;
                else if (index == 1)
                    this.dogWeight = (int)value;
                else if (index == 2)
                    this.dogBreed = (string)value;
                else if (index == 3)
                    this.dogName = (string)value;
                else if (index == 4)
                    this.dogKennel = (int)value;

            }





        }

        public object this[string attrName] //"String value"
        {
            get
            {
                if (attrName.ToLower().Equals("employeeNr"))
                    return this.age;
                if (attrName.ToLower().Equals("jobTitle"))
                    return this.dogWeight;
                if (attrName.ToLower().Equals("name"))
                    return this.dogBreed;
                if (attrName.ToLower().Equals("surname"))
                    return this.dogName;
                if (attrName.ToLower().Equals("salary"))
                    return this.dogKennel;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("employeeNr"))
                    this.age = (int)value;
                if (attrName.ToLower().Equals("jobTitle"))
                    this.dogWeight = (int)value;
                if (attrName.ToLower().Equals("name"))
                    this.dogBreed = (string)value;
                if (attrName.ToLower().Equals("surname"))
                    this.dogName = (string)value;
                if (attrName.ToLower().Equals("salary"))
                    this.dogKennel = (int)value;

            }



        }



    }
}
