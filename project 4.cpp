#include<iostream>
#include<string>
using namespace std;
class item
{
private:
       char m[121][6];
       int Roomno[121]={401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904};
       string i,j
public:
      void FillTDArrayWithNoSubject(void);
      void  CheckArray(void);
      void  ShowArray(void);
      //void InsertSingleCourseIntoPosition(void);
};
void item::FillTDArrayWithNoSubject(void)
{
     for(i=1; i<=121; i++)
    {
        for(j=1; j<=6; j++)
        {
            m[i][j]='-';
        }
    }
}
void item::CheckArray(void)
{
    int column,row,k,rowAddition,temprow;
    char Course[8],C,temp;
    for(k=1; k<=8; k++)
        cout<<Course[k];
    temprow = Course[5]-48;
    if(temprow==1)
        row=1;
    else if(temprow==2)
        row=7;
    else if(temprow==3)
        row=13;
    else
        row=19;
    rowAddition = Course[6]-48;
    cout<<column,C;
    for(i=1;i<=121;i++)
    {
        for(j=1; j<=6; j++)
        {
            //Monday
            if(i==row && j==column)
            {
                //1st semester
                if(rowAddition==1)
                {
                    m[i][j]=C;
                    m[i+1][j]=C;
                }
                //2nd semester
                else if(rowAddition==2)
                {
                    m[i+2][j]=C;
                    m[i+3][j]=C;
                }
                //3rd semester
                else
                {
                    m[i+4][j]=C;
                    m[i+5][j]=C;
                }
            }
            //Tuesday
            else if(i==row+24 && j==column)
            {
                //1st semester
                if(rowAddition==1)
                {
                    m[i][j]=C;
                    m[i+1][j]=C;
                }
                //2nd semester
                else if(rowAddition==2)
                {
                    m[i+2][j]=C;
                    m[i+3][j]=C;
                }
                //3rd semester
                else
                {
                    m[i+4][j]=C;
                    m[i+5][j]=C;
                }
            }
            //Wednesday
            else if(i==row+72 && j==column)
            {
                //1st semester
                if(rowAddition==1)
                {
                    m[i][j]=C;
                    m[i+1][j]=C;
                }
                //2nd semester
                else if(rowAddition==2)
                {
                    m[i+2][j]=C;
                    m[i+3][j]=C;
                }
                //3rd semester
                else
                {
                    m[i+4][j]=C;
                    m[i+5][j]=C;
                }
            }
            //Thursday
            else if(i==row+96 && j==column)
            {
                //1st semester
                if(rowAddition==1)
                {
                    m[i][j]=C;
                    m[i+1][j]=C;
                }
                //2nd semester
                else if(rowAddition==2)
                {
                    m[i+2][j]=C;
                    m[i+3][j]=C;
                }
                //3rd semester
                else
                {
                    m[i+4][j]=C;
                    m[i+5][j]=C;
                }
            }

        }
    }

}
void item::ShowArray(void)
{
      cout<<endl;
    for(i=1; i<121; i++)
    {
        cout<<i;
        for(j=1; j<=6; j++)
        {
            cout<<m[i][j];
        }
        cout<<Roomno[i-1];
        cout<<endl;
    }
}
int main()
{
    item obj();
    obj.FillTDArrayWithNoSubject();
    boj.CheckArray();
    obj.ShowArray();
    return 0;
}
