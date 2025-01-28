import math
def bmi():
    wt=float(input("Enter the weight in kgs:"))
    ht=float(input("Enter the height in meters:"))
    bmi= wt/(ht*ht)
    print(f"The bmi value is:{bmi}")
    if(bmi<18.5):
        print("The person body isunderweight")
    elif(bmi>=18.5 and bmi<=24.9):
        print("The person body is healthy")
    elif(bmi>24.9):
        print("The person body is overweight")
    else:
        print("enter correct values")
bmi()
