class student:
    def __init__(self,name,rollno,age,cls):
        self.name=name
        self.rollno=rollno
        self.age=age
        self.cls=cls
        
    def display(self):
        print(f"The name is:{self.name}\n,the rollno is :{self.rollno}\n,The age is{self.age}\n,The class is {self.cls}")
obj = student("sri",123,21,"Final year")
obj.display()