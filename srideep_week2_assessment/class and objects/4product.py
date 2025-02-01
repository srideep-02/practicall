class product:
    def __init__(self,name,price,stock,avail):
        self.name=name
        self.price=price
        self.stock=stock
        self.avail=avail
    def check_availability(self):
        req=int(input("Enter the number of quantity"))
        if (req>=1):
            print("The stock is available \n you caan purchase the product\n")
            self.avail -= req
            print(f"The name is:{self.name}\nthe price is :{self.price}\nThe required products is{req} stock present is{self.stock}")
            print(f"Stock available is :{self.avail}")
        else:
            print("OUT OF STOCK")
            
obj = product("apple",3000,20,10)
obj.check_availability()