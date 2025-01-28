def check_balance():
    amount=500
    print("Minimum balance in the accout is '500' ")
    while True:
        print("Enter 1-Balance Enquiry  2-Money Deposit  3-money Withdrawl  4-Exit")
        n=int(input("Enter the digit"))
        if (n==1):
            print(f"The balance amount is:{amount}")
        elif (n==2):
            amt1=int(input("Enter the deposit amount"))
            amount=amount+amt1
            print("The money is deposited successfully")
        elif(n==3):
            amt2=int(input("Enter the withdrawl amount"))
            amount=amount-amt2
            print("The money is withdrawed successfully")
        elif(n==4):
            print("Thankyou!")
            break
        else:
            print("Enter the corect option")
       
def main():
    check_balance()
main()