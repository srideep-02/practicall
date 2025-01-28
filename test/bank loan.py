def get_input():
    age=int(input("Enter age:"))
    salary=int(input("Enter salary:"))
    credit_score=int(input("Enter credit score:"))
    return (age,salary,credit_score)
def check_eligibility(age,salary,credit_score):
    if (age>=18 and salary>=30000):
        if (credit_score>650):
            print("You are eligible for the loan ")
        else:
            print("You are not eligible for the loan because u have low credit score")
    else:
        print("You are not eligible for the loan due to less salary or u are under 18 years")
def main():
    (age,salary,credit_score)=get_input()
    check_eligibility(age,salary,credit_score)
main()
        
        

            