#include<iostream>
#include<string>
using namespace std;
class item
{
    string TeacherStatus[2],CourseCode[2],RoutineArray[6];
    int l,column[2],Index;
public:
    void getdata(void);
};
void item::getdata(void)
{
    cout<<"Enter your number:";
    cin>>l;
    for(int j=0;j<=5;j++)
    {
        RoutineArray[j]="-";
    }
    for(int i=0;i<=l;i++)
    {
    cout<<"Enter your status:";
    cin>>TeacherStatus[i];
    cout<<"Enter your course code:";
    cin>>CourseCode[i];
    cout<<"Enter your column:";
    cin>>column[i];
    if(TeacherStatus[i]=="Visiting Faculty member")
    {
        Index=column[i];
        RoutineArray[Index]=CourseCode[i];
    }
    else
    {
        cout<<"Nobhfghf";
    }
    }
    for(int k=0;k<=5;k++)
    {
        cout<<RoutineArray[k];
    }
}
int main()
{
    item obj;
    obj.getdata();
    return 0;
}
