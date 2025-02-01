class bankaccount:
    def __init__(self,balance=0,overdraft=500):
        self.balance=balance
        self.overdraft=overdraft 
  
        
    def deposit(self,amount):
        self.balance += amount 
        print(f"The available balance is: {amount} after deposit is :{self.balance}")
        
    def withdraw(self,amount):
        if(self.balance-amount >= self.overdraft):
            self.balance -= amount
            print(f"The transaction is successful balance after withdraw is :{self.balance}")    
        else:
            print("Transaction is denied !Limit exceeded ")
obj = bankaccount(balance=1000,overdraft=500)

obj.deposit(500)
obj.withdraw(1000)
