#include<stdio.h>
char RoutineArray[121][6];
int Roomno[121]= {401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904,401,402,403,404,501,502,503,504,601,602,603,604,701,702,703,704,801,802,803,804,901,902,903,904};
int RoutineArrayRowIndex,RoutineArrayColumnIndex;
float CourseCredit;
int column,row,CourseCodeCharStringArrayIndex,SemesterDeterminingCourseCodeDigit,YearDeterminingCourseCodeDigit;
char Course[8],C,temp;
int l;
FillTDArrayWithNoSubject()
{
    for(RoutineArrayRowIndex=1; RoutineArrayRowIndex<=121; RoutineArrayRowIndex++)
    {
        for(RoutineArrayColumnIndex=1; RoutineArrayColumnIndex<=6; RoutineArrayColumnIndex++)
        {
            RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]='-';
        }
    }
}
CheckArray()
{
    //int l,o;
    //scanf("%d",&l);
    //for(o=0;o<l;o++)
    {
    for(CourseCodeCharStringArrayIndex=1; CourseCodeCharStringArrayIndex<=8; CourseCodeCharStringArrayIndex++)
        {
        scanf("%c",&Course[CourseCodeCharStringArrayIndex]);
        }
    scanf("%d %c %f",&column,&C,&CourseCredit);
    YearDeterminingCourseCodeDigit = Course[5]-48;
    if(YearDeterminingCourseCodeDigit==1)
        row=1;
    else if(YearDeterminingCourseCodeDigit==2)
        row=7;
    else if(YearDeterminingCourseCodeDigit==3)
        row=13;
    else
        row=19;
    SemesterDeterminingCourseCodeDigit = Course[6]-48;
    if(CourseCredit == 1.5 || CourseCredit == 0.75)
    {
        DoubleTimeSlotAssign();
    }
    else
    {
        SingleTimeSlotAssign();
    }
    }

}
ArrayConditionForSemesterTheory()
{
                //1st semester
                if(SemesterDeterminingCourseCodeDigit==1)
                {
                    RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=C;
                    RoutineArray[RoutineArrayRowIndex+1][RoutineArrayColumnIndex+1]=C;
                }
                //2nd semester
                else if(SemesterDeterminingCourseCodeDigit==2)
                {
                    RoutineArray[RoutineArrayRowIndex+2][RoutineArrayColumnIndex]=C;
                    RoutineArray[RoutineArrayRowIndex+3][RoutineArrayColumnIndex+1]=C;
                }
                //3rd semester
                else
                {
                    RoutineArray[RoutineArrayRowIndex+4][RoutineArrayColumnIndex]=C;
                    RoutineArray[RoutineArrayRowIndex+5][RoutineArrayColumnIndex+1]=C;
                }
}
ArrayConditionForSemesterLab()
{
                //1st semester
                if(SemesterDeterminingCourseCodeDigit==1)
                {
                    RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=C;
                    RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex+1]=C;
                    RoutineArray[RoutineArrayRowIndex+1][RoutineArrayColumnIndex+2]=C;
                    RoutineArray[RoutineArrayRowIndex+1][RoutineArrayColumnIndex+3]=C;
                    Roomno[RoutineArrayRowIndex-1]=301;
                    Roomno[RoutineArrayRowIndex]=302;
                }
                //2nd semester
                else if(SemesterDeterminingCourseCodeDigit==2)
                {
                    RoutineArray[RoutineArrayRowIndex+2][RoutineArrayColumnIndex]=C;
                    RoutineArray[RoutineArrayRowIndex+2][RoutineArrayColumnIndex+1]=C;
                    RoutineArray[RoutineArrayRowIndex+3][RoutineArrayColumnIndex+2]=C;
                    RoutineArray[RoutineArrayRowIndex+3][RoutineArrayColumnIndex+3]=C;
                    Roomno[RoutineArrayRowIndex+2-1]=303;
                    Roomno[RoutineArrayRowIndex+3-1]=304;
                }
                //3rd semester
                else
                {
                    RoutineArray[RoutineArrayRowIndex+4][RoutineArrayColumnIndex]=C;
                    RoutineArray[RoutineArrayRowIndex+4][RoutineArrayColumnIndex+1]=C;
                    RoutineArray[RoutineArrayRowIndex+5][RoutineArrayColumnIndex+2]=C;
                    RoutineArray[RoutineArrayRowIndex+5][RoutineArrayColumnIndex+3]=C;
                    Roomno[RoutineArrayRowIndex+4-1]=301;
                    Roomno[RoutineArrayRowIndex+5-1]=302;
                }
}
SingleTimeSlotAssign()
{
    for(RoutineArrayRowIndex=1; RoutineArrayRowIndex<=121; RoutineArrayRowIndex++)
    {
        for(RoutineArrayColumnIndex=1; RoutineArrayColumnIndex<=6; RoutineArrayColumnIndex++)
        {
            //Monday
            if(RoutineArrayRowIndex==row && RoutineArrayColumnIndex==column && RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=='-')
            {
                ArrayConditionForSemesterTheory();
            }
            //Tuesday
            else if(RoutineArrayRowIndex==row+24 && RoutineArrayColumnIndex==column && RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=='-')
            {
                ArrayConditionForSemesterTheory();
            }
            //Wednesday
            else if(RoutineArrayRowIndex==row+72 && RoutineArrayColumnIndex==column && RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=='-')
            {
                ArrayConditionForSemesterTheory();
            }
            //Thursday
            else if(RoutineArrayRowIndex==row+96 && RoutineArrayColumnIndex==column && RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=='-')
            {
                ArrayConditionForSemesterTheory();
            }
        }
    }
}
DoubleTimeSlotAssign()
{
    for(RoutineArrayRowIndex=1; RoutineArrayRowIndex<=121; RoutineArrayRowIndex++)
    {
        for(RoutineArrayColumnIndex=1; RoutineArrayColumnIndex<=6; RoutineArrayColumnIndex++)
        {
            //Monday
            if(RoutineArrayRowIndex==row && RoutineArrayColumnIndex==column && RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=='-')
            {
                ArrayConditionForSemesterLab();
            }
            //Tuesday
            else if(RoutineArrayRowIndex==row+24 && RoutineArrayColumnIndex==column && RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=='-')
            {
                ArrayConditionForSemesterLab();
            }
            //Wednesday
            else if(RoutineArrayRowIndex==row+72 && RoutineArrayColumnIndex==column && RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=='-')
            {
                ArrayConditionForSemesterLab();
            }
            //Thursday
            else if(RoutineArrayRowIndex==row+96 && RoutineArrayColumnIndex==column && RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]=='-')
            {
                ArrayConditionForSemesterLab();
            }
        }
    }
}
ShowArray()
{
    printf("\n");
    for(RoutineArrayRowIndex=1; RoutineArrayRowIndex<121; RoutineArrayRowIndex++)
    {
        printf("[%d]",RoutineArrayRowIndex);
        for(RoutineArrayColumnIndex=1; RoutineArrayColumnIndex<=6; RoutineArrayColumnIndex++)
        {
            printf(" %c ",RoutineArray[RoutineArrayRowIndex][RoutineArrayColumnIndex]);
        }
        printf("%d",Roomno[RoutineArrayRowIndex-1]);
        printf("\n");
    }
}
InsertSingleCourseIntoPosition()
{


    //FillTDArrayWithNoSubject();
    CheckArray();
    //ShowArray();
}
main()
{
    int j;
    scanf("%d",&l);
    FillTDArrayWithNoSubject();
    //
    //for(j=0;j<l;j++)
    InsertSingleCourseIntoPosition();
    ShowArray();
}
