using System;
namespace oop;
public class Department {
  public string Name ;
  public float Compen;
  public Department(string name, float comp){
    Name =name;
    Compen=comp;
  }
  public virtual double Getsalary(double salary, int workingdays){
    return (salary*workingdays)+(salary*workingdays)*(Compen/100);
  }
}
public class Employee {
  public string Fname;
  public string Lname;
  public double Salary;
  Department department;
  public Employee(string fname,string lname,double salary,Department depart){
    Fname=fname;
    Lname=lname;
    Salary=salary;
    department=depart;
  }
  public double Getsalary(int workingdays){
    return department.Getsalary(Salary,workingdays);
  }

}
public class Database{
 public  Department[] departments=new Department[50];
  public Employee[] employees=new Employee[50];
  public int index1=0;
  public int index2=0;
  public void adddepartment(Department department){
    departments[index1]=department;
    index1++;
  }
  public void addemployees(Employee employee){
    employees[index2]=employee;
    index2++;
  }
}
class program{
  public static void Main(){
     
    Database data=new Database();
    while(true){
      Console.WriteLine("1)ADD Department\n2)ADD Employee");
      var i=Convert.ToInt32(Console.ReadLine());
      if(i==1){
        Console.Write("Department Name : ");
        var name=Console.ReadLine();
        Console.Write("Compensaion : ");
        var comp=Convert.ToSingle(Console.ReadLine());
        Department depar =new Department(name,comp);
        data.adddepartment(depar);
        Console.WriteLine("Department Add Successfully");
      }
      else if (i==2){
          Console.Write("First Name : ");
        var fname=Console.ReadLine(); 
         Console.Write("Last Name : ");
        var lname=Console.ReadLine();
         Console.Write("Salary : ");
        var salary=Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter the index of the Department : ");
        var j=Convert.ToInt32(Console.ReadLine());
        Employee employee=new Employee(fname,lname,salary,data.departments[j]);
        data.addemployees(employee);
         Console.WriteLine("Employee Add Successfully");

      }
    }
  }
}




