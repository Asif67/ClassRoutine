#include<iostream>
#include<string>

using namespace std;
class item
{
    string a,year,result,sem;
    int l;

public:
    void input(void);

};
void item::input(void)
{
    cout<<"Enter your Number";
    cin>>l;
    cout<<"Enter your CourseCode";
    for(int i=1;i<=l;i++)
    {
    cin>>a;

    year=a.substr(4,1);
    sem=a.substr(5,1);
    if(year=="1")
    {
         if(sem=="1")
            {
             result="1st year 1st sem";
            }
         else if(sem=="2")
         {
             result="1st year 2nd sem";
         }
         else
         {
              result="1st year 3rd sem";
         }
    }
    else if(year=="2")
    {
        if(sem=="1")
        {
            result="2nd year 1st sem";
        }
        else if(sem=="2")
        {
             result="2nd year 2nd sem";
        }
        else
        {
             result="2nd year 3rd sem";
        }
    }
    else if(year=="3")
    {
        if(sem=="1")
        {
            result="3rd  year 1st sem";
        }
        else if(sem=="2")
        {
             result="3rd year 2nd sem";
        }
        else
        {
             result="3rd year 3rd sem";
        }

    }
    else if(year=="4")
    {
        if(sem=="1")
        {
            result="4th year 1st sem";
        }
        else if(sem=="2")
        {
             result="4th  year 2nd sem";
        }
        else
        {
             result="4th year 3rd sem";
        }

    }

    cout<<result<<endl;
    }
}
int main()
{
    item obj;
    obj.input();
    return 0;
}



