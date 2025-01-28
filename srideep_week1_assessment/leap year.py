def get_input():
    year=int(input("Enter the year"))
    return year
def get_leap_year(year):
    if(year%4==0):
        print(f"{year} is leap year")
    else:
        print(f"{year} is not a leap year")
def main():
    year=get_input()
    leapyear=get_leap_year(year)
main()
