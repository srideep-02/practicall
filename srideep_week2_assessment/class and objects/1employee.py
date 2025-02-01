class employee:
    # def __init__(self,name,id,dept):
    #     self.name = name
    #     self.id = id
    #     self.dept = dept
        
    def display(self):
        # print(f"Name:{self.name},id:{self.id},dept:{self.dept}")
        self.name = input("Enter name:")
        self.id = int(input("Enter id:"))
        self.dept = input("Enter dept:")
        print(f"Name:{self.name},id:{self.id},dept:{self.dept}")


# obj=employee("qwerty",38,"csc")
obj=employee()
obj.display()

        