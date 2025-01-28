import math
def get_input():
    name=input("Enter student name:")
    s1=int(input("Enter sub1 Marks: "))
    s2=int(input("Enter sub2 Marks: "))
    s3=int(input("Enter sub3 Marks: "))
    s4=int(input("Enter sub4 Marks: "))
    s5=int(input("Enter sub5 Marks: "))
    return (name,s1,s2,s3,s4,s5)
def get_result(name,s1,s2,s3,s4,s5):
    total_marks=500
    sum=s1+s2+s3+s4+s5
    print(f"Total marks obtained are :{sum}")
    result=(sum/total_marks)*100
    print(f"The percentage is {result}")
    if(result>90):
        print("A Grade")
    elif(result>80):
        print("B Grade")
    elif(result>70):
        print("C Grade")
    elif(result>60):
        print("D Grade")
    else:
        print("Fail")
    
def main():
    (name,s1,s2,s3,s4,s5)=get_input()
    get_result(name,s1,s2,s3,s4,s5)
main()
    