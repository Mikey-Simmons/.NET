class Employee {
    constructor(name, salary, hireDate) {
      this.name = name;
      this.salary = salary;
      this.hireDate = hireDate;
    }
    getName() {
      console.log(this.name.toUpperCase());
    }
    getSalary() {
      console.log(this.salary);
    }
    getHireDate() {
      console.log(this.hireDate);
    }
  }
  class Manager extends Employee{
    constructor(name,salary,hireDate, descriptionOfJob){
        super(name,salary,hireDate);
        this.descriptionOfJob = descriptionOfJob;
    }
    jobDescription(){
        console.log(this.name+"  Hire Date:" + this.hireDate+" Salary: "+this.salary+" Job Description: " +this.descriptionOfJob)
    }
  }
class Designer extends Employee{
    constructor(name,salary,hireDate, yearsOfExperience){
        super(name,salary,hireDate);
        this.yearsOfExperience = yearsOfExperience;
    }
    yearsExperience(){
        console.log(this.name+"  Hire Date:" + this.hireDate+" Salary: "+this.salary+" Years of Experience: " +this.yearsOfExperience)
    }
}
class SalesAssociate extends Employee{
    constructor(name,salary,hireDate,degreeCompleted){
        super(name,salary,hireDate);
        this.degreeCompleted = degreeCompleted;
    }
    degreeComplete(){
        console.log(this.name+"  Hire Date:" + this.hireDate+" Salary: "+this.salary+" Degrees Completed: " +this.degreeCompleted)
    }
}
var myManager = new Manager("Mikey",50000,"1/1/2020","Manager on duty");
var myDesigner = new Designer("Rob",500000,"1/1/2022",5);
var mySales = new SalesAssociate("Bobby",50000000,"1/12/2022","Bachelors");

myManager.jobDescription();
myDesigner.yearsExperience();
mySales.degreeComplete();

