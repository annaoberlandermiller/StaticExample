using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
	class Technology
	{
		public static int Counter { get; set; } = 0;
		public int Id { get; set; }
		public string Name { get; set; }
		public int Difficulty { get; set; }
		private void Initialization()  //this, along with the first constructor, allows us to set the name and the difficulty = to the parameters (see EF on program tab)
		{
			Id = ++Counter;
			Difficulty = 3;
		}

		public Technology(string name, int difficulty)
		{
			Initialization();
			Name = name;
			Difficulty = difficulty;
		}
		
		
		public Technology(string name) {  //"name" in string name must be lower case because the assignment on the next line also has it lower case.
			Name = name;				  //if the parameter and the property are the same (same characters AND case), put ".this" in front of your property
			Id = ++Counter;			      // think:  this thing I'm creating = property
			Difficulty = 3;
		}
		// We have 2 of these right now because the bottom one is saying if we don't name a new tech, this will be the default 
		// These 2 constructs can both exist because they have different parameters.
		// The top one has string name as a parameter

		public Technology()  //this will assign a unique Id to every new technology that we make.  
							 //It needs to be in a constructor if you want each new instance(in this case, each new technology) to automatically have a unique ID
							 //This is a constructor - it is a method that is the same name as the class it is in.
		{
			Id = ++Counter;
			Difficulty = 3; //this is setting 3 as the default value 
		}
	}
}
