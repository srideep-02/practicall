import random
def get_value():
    number=random.randint(1,100)
    print(f"The random number is {number}")
    return number
def guess_number(num):
    count=0
    while True:
        user=int(input("Enter the number for guessing"))
        count=count+1
        if(count>=3):
            break
        elif(user>num):
            
            print("Too high,Try again!!")
        elif(user<num):
            print("Too low,Try again!!")
        else:
            print("!!!Congratulayions u have guessed the correct number!!!")
            break
        print("Guessing limit exceeded")
def main():
    number=get_value()
    guess_number(number)
main()