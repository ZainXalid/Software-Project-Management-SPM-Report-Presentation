#include<iostream>
#include <cstdio>
using namespace std;

struct p   //Struct that act as an datatype for all the properties of a process
{
    int process_id, waiting_time, burst_time, total_time;
    int  priority, arrival_time, turnaround_time;
    int remain_time, copy_burst_time;
};

struct process   //Struct that act as an datatype for all the properties of a process
{
    int process_id, waiting_time, burst_time, total_time;
    int  priority, arrival_time, turnaround_time;
    int remain_time, copy_burst_time;
};

int main()
{
    p arr[30], temp;
    int process_finish[100];
    string user_name, password;
    int tryy = 5, remain = 0;

    //Module 01
    //Login

    cout << "+-----+---------+-----------+-----------+--------+" <<endl;
    cout << "|             Operating System Project           |" << endl;
    cout << "+-----+---------+-----------+-----------+--------+" << endl;
    cout << "|             CPU Scheduling Algorithms          |" << endl;
    cout << "+-----+---------+-----------+-----------+--------+\n\n\n" << endl;

    do     //Repeat Whole Program
    {

        do   //Password Check
        {
            if (remain == 1 && tryy >= 1)
            {
                cout << "Invaild Username or Password! Please try again..." << endl;
                cout << "You have only " << tryy << " try left.\n";
            }

       

            cout << "Enter Username (Hint : a) " << endl;
            cin >> user_name;
            cout << "Enter Password (Hint : b) " << endl;
            cin >> password;
            remain = 1;
            tryy--;

            if (tryy < 1)
            {
                cout << "\nAccess Denied. Please try later.";

                exit(0);
            }
        } while (user_name != "a" || password != "b");  


        //Module 02
        //Project Group Member Detail

        cout << "\n\nAccess granted" << endl;
        cout << "Welcome to the project\n" << endl;
        cout << "+------+---------+------+------+:" << endl;
        cout << "|      Project Members are:    |" << endl;
        cout << "+--------+---------+------+----+:\n" << endl;

        cout << "01. Zohaib Mehmood (FA19-BCS-087)" << endl;
        cout << "02. Zain Khalid (FA19-BCS-112)" << endl;
        cout << "03. Wajahat Ali Khan (FA19-BCS-192)" << endl;;
        cout << "04. Sugra (FA19-BCS-205)" << endl;;



        //Module 03
        //Project Description and Menu

        int continue_;
        int choice;
        do
        {
            string x;

        cout << "+--------+---------+------+----+" << endl;
        cout << "|        The Main Menue        |" << endl;         
        cout << "+--------+---------+------+----+:" << endl;
            
        cout << "Press 01 for FCFS" << endl;
        cout << "Press 02 for SJF" << endl;
        cout << "Press 03 for Priorty" << endl;
        cout << "Press 04 for Round Robin" << endl;
        cout << "Press 05 for SRT" << endl;
        cout << "+--------+---------+------+----+:" << endl;
            
        cout << "\nEnter your choice : ";

        cin >> choice;
        cout<< endl;

            switch (choice)
            {
            case  1:

            {
                int i, n, j, totalwait = 0, totalser = 0, avturn, avwait;
                cout << "Enter the number of processes : ";
                cin>>n;

                for (i = 1;i <= n; i++)
                {
                   
                     arr[i].process_id = i;
                     cout << "For Process id : " << arr[i].process_id<< endl;
                    cout << "Enter Process Burst Time"<<endl;
                    cin >> arr[i].burst_time;
                }

                arr[1].waiting_time = 0;

                arr[1].total_time = arr[1].burst_time;

                for (i = 2, j=1 ;i <= n;i++, j++)
                {
                   arr[i].waiting_time = arr[j].waiting_time + arr[j].burst_time;
                    totalwait = totalwait + arr[i].waiting_time;
                    arr[i].total_time = arr[i].waiting_time + arr[i].burst_time;
                    totalser = totalser + arr[i].total_time;
                }

                avturn = totalser / n;
                avwait = totalwait / n;

                cout << "+-------+-------+---------+---------+" << endl;
                cout << "|   Id  | Burst |   wait  | total   |" << endl;
                cout << "+-------+-------+---------+---------+" << endl;
                for (int i = 1; i <= n; i++)
                {
                    cout << "|  " << arr[i].process_id;

                    if(arr[i].burst_time>9)
                    cout << "   |  " << arr[i].burst_time;
                    else
                    cout << "    |  " << arr[i].burst_time;

                    if(arr[i].waiting_time>9)
                    cout << "      |  " << arr[i].waiting_time;
                    else
                    cout << "    |  " << arr[i].waiting_time;

                    if(arr[i].total_time>9)
                    cout << "   | " << arr[i].total_time;
                    else
                    cout << "     |  " << arr[i].total_time;

                    cout << "      |"<<endl;
                }


                cout << "+-------+-------+---------+---------+\n" << endl;

                cout << "Total Waiting Time      :" << totalwait << endl;
                cout << "Average Waiting Time    :" << avwait << endl;
                cout << "Total Turnaround Time   :" << totalser << endl;
                cout << "Average Turnaround Time :" << avturn << endl;
                cout<<"\n      GANTT CHART"<<endl;

                cout<<" ";
                for (i = 1; i <= n; i++) {
                     cout<<"----  ";
                    
                }
                cout<<"\n|";

                for (i = 1; i <= n; i++) {
                    cout<<" ";
                    cout<<"p"<< arr[i].process_id;
                    cout<<"  |";
                    
                }
                cout<<"\n ";
                for (i = 1; i <= n; i++) {
                  cout<<"----  ";
                }
                 cout<<"\n0";
                for (i = 1; i <= n; i++) {
                    if (arr[i].total_time > 9) cout<<"     ";
                    else
                        cout << "     ";
                    cout<< arr[i].total_time;

                }
                cout<<"\n";



            }
            break;
            case 2:
            {
                
                int i, j, n, totwt, tottt;
                float avg1, avg2;

                cout<<"\nEnter the number of process:\t";
                cin>>n;
                for (i = 1;i <= n;i++)
                {
                    arr[i].process_id = i;
                    cout<<"\nEnter the burst time:\t";
                    cin >> arr[i].burst_time;
                }
                for (i = 1;i < n;i++) {
                    for (j = i + 1;j <= n;j++)
                    {
                        if (arr[i].burst_time > arr[j].burst_time)
                        {
                            temp.process_id = arr[i].process_id;
                            arr[i].process_id = arr[j].process_id;
                            arr[j].process_id = temp.process_id;
                            temp.burst_time = arr[i].burst_time;arr[i].burst_time = arr[j].burst_time;
                            arr[j].burst_time = temp.burst_time;
                        }
                    }
                }
                arr[1].waiting_time = 0;
                arr[1].total_time = arr[1].burst_time + arr[1].waiting_time;
                i = 2;
                while (i <= n) {
                    arr[i].waiting_time = arr[i - 1].burst_time + arr[i - 1].waiting_time;
                    arr[i].total_time = arr[i].burst_time + arr[i].waiting_time;
                    i++;
                }
                i = 1;
                totwt = tottt = 0;

                cout << "+--------+------------+------------+"<<endl;
                cout<<"|Process id \tbt \twt \ttt |"<<endl;
                cout << "+--------+------------+------------+" << endl;
                while (i <= n) {
                    cout<<"\n\t"<<arr[i].process_id<< "\t"<< arr[i].burst_time<<"\t"<< arr[i].waiting_time<<"\t"<< arr[i].total_time<<"\n";
                    totwt = arr[i].waiting_time + totwt;
                    tottt = arr[i].total_time + tottt;
                    i++;
                }
                cout << "+--------+------------+------------+" << endl;
                avg1 = totwt / n;
                avg2 = tottt / n;
                cout<<"\nAverage Waiting Time = "<< avg1<<"\tAVG2 = "<<avg2;

                cout<<"\n\n          GANTT CHART          "<<endl;

                int x, y;

                cout << " ";
                for (x = 0; x < n; x++) {
                    cout<<"---- ";
                   
                }
                cout << "\n|";

                for (x = 0; x < n; x++) {
                    cout<<" ";
                    cout << "p" << arr[x + 1].process_id;
                    cout<<" ";
                    cout << "|";
                }
                cout << "\n ";

                for (x = 0; x < n; x++) {
                     cout << "---- ";
         
                }
                cout << "\n";


                int last = arr[n].total_time;

                cout << "0";
                for (x = 2; x <= n; x++)
                {
                    cout << "    " << arr[x].waiting_time;
               }
                cout << "  " << last;

                
            }
            break;

            case 3:
            {

                int i, j, n, total = 0, pos, temp, avg_wt, avg_tat;
                int total_waiting_time, sum_waiting_time = 0,  sum_turnaround_time = 0;
             
                cout << "Enter Total Number of Process : ";
                cin >> n;
                for (i = 0;i < n;i++)
                {
                    cout << "Enter Burst Time : ";
                    cin >> arr[i].burst_time;
                    cout << "Enter Priority  : ";
                    cin>> arr[i].priority;

                    arr[i].process_id = i + 1;           //contains process number

                   arr[i].waiting_time = arr[i].turnaround_time = 0;

                }

                //sorting burst time, priority and process number in ascending order using selection sort
                for (i = 0;i < n;i++)
                {
                    pos = i;
                    for (j = i + 1;j < n;j++)
                    {
                        if (arr[j].priority < arr[pos].priority)
                            pos = j;
                    }

                    temp = arr[i].priority;
                    arr[i].priority = arr[pos].priority;
                    arr[pos].priority = temp;

                    temp = arr[i].burst_time;
                    arr[i].burst_time = arr[pos].burst_time;
                    arr[pos].burst_time = temp;

                    temp = arr[i].process_id;
                    arr[i].process_id = arr[pos].process_id;
                    arr[pos].process_id = temp;
                }



                arr[0].turnaround_time = arr[0].burst_time;

                for (i = 1; i < n; i++) {
                    arr[i].waiting_time = arr[i - 1].waiting_time + arr[i - 1].burst_time;
                    arr[i].turnaround_time = arr[i].waiting_time + arr[i].burst_time;
                }

                for (i = 0; i < n; i++) {
                    sum_waiting_time += arr[i].waiting_time;
                    sum_turnaround_time += arr[i].turnaround_time;
                }


                avg_wt = total / n;      //average waiting time
                total = 0;



                cout << "\n\n+-----+------------+--------------+-----------------+-----------------+" << endl;


                cout << "| PID | PRIORITY | Waiting Time | Turnaround Time |  Burst Time        |" << endl;


                cout << "+-----+------------+--------------+-----------------+-----------------+" << endl;

                for (i = 0; i < n; i++) {
                    total += arr[i].turnaround_time;

                    cout << "| " << arr[i].process_id << "       |       " << arr[i].priority << "  |     " << arr[i].burst_time << "     |      " << arr[i].waiting_time << "      |        " << arr[i].turnaround_time << "       |" << endl;
                }
                cout << "+-----+------------+--------------+-----------------+-----------------+" << endl;




                avg_tat = total / n;     //average turnaround time
                cout << "Total Waiting Time : " << sum_waiting_time << endl;
                cout << "Average Waiting Time    : " << (double)sum_waiting_time / (double)n<<endl;
                cout << "Total Turnaround Time   : " << sum_turnaround_time<<endl;
                cout << "Average Turnaround Time : " << (double)sum_turnaround_time / (double)n<<endl;






                cout << "\n\n          GANTT CHART          " << endl;
                for (i = 0; i < n; i++) {
                    for (j = 0; j < arr[i].burst_time; j++) cout << "--";
                    cout << " ";
                }
                cout << "\n|";

                for (i = 0; i < n; i++) {

                    for (j = 0; j < arr[i].burst_time - 1; j++) cout << " ";

                    cout << arr[i].process_id;
                    for (j = 0; j < arr[i].burst_time - 1; j++) cout << " ";
                    cout << "|";
                }
                cout << "\n ";
                for (i = 0; i < n; i++) {

                    for (j = 0; j < arr[i].burst_time; j++) cout << "--";
                    cout << " ";
                }
                cout << "\n";

                cout << "0";
                for (i = 0; i < n; i++) {
                    for (j = 0; j < arr[i].burst_time; j++)

                        cout << "  ";


                    if (arr[i].turnaround_time > 9) cout << "\b";
                    cout << arr[i].turnaround_time;

                }
                cout << "\n";
            }
            break;
            case 4:
            {

                int i, j, pro, time, remain, flag = 0, ts;
                struct p a[100];
                float avgwt = 0, avgtt = 0;
                cout << "Round Robin Scheduling Algorithm\n";
                cout << "Enter Number Of Processes : ";
                cin >> pro;
                remain = pro;
                for (i = 0;i < pro;i++)
                {
                    cout << "\nEnter arrival time for Process " << i + 1 << ": ";
                    cin >> a[i].arrival_time;
                    cout << "\nEnter burst time for Process " << i + 1 << ": ";
                    cin >> a[i].burst_time;
                    a[i].process_id = i;
                    a[i].copy_burst_time = a[i].burst_time;
                }

                cout << "\nEnter Time Slice OR Quantum Number : ";
                cin >> ts;


                cout << "\n***************\n";
                cout << "Gantt Chart\n";
                cout << "0";
                for (time = 0, i = 0;remain != 0;)
                {
                    if (a[i].copy_burst_time <= ts && a[i].copy_burst_time > 0)
                    {
                        time = time + a[i].copy_burst_time;
                        cout << " -> [P" << a[i].process_id << "] <-" << time;
                        a[i].copy_burst_time = 0;
                        flag = 1;
                    }
                    else if (a[i].copy_burst_time > 0)
                    {
                        a[i].copy_burst_time = a[i].copy_burst_time - ts;
                        time = time + ts;
                        cout << " -> [P" << a[i].process_id << "] <-" << time;
                    }
                    if (a[i].copy_burst_time == 0 && flag == 1)
                    {
                        remain--;
                        a[i].turnaround_time = time - a[i].arrival_time;
                        a[i].waiting_time = time - a[i].arrival_time - a[i].burst_time;
                        avgwt = avgwt + time - a[i].arrival_time - a[i].burst_time;
                        avgtt = avgtt + time - a[i].arrival_time;
                        flag = 0;
                    }
                    if (i == pro - 1)
                        i = 0;
                    else if (a[i + 1].arrival_time <= time)
                        i++;
                    else
                        i = 0;
                }
                cout << "\n\n";
                cout << "*************\n";
                cout << "Process\tAT\tBT\tTAT\tWT\n";
                cout << "*************\n";
                for (i = 0;i < pro;i++)
                {
                    cout << "P" << a[i].process_id << "\t" << a[i].arrival_time << "\t" << a[i].burst_time << "\t" << a[i].total_time << "\t" << a[i].waiting_time << endl;
                }
                cout << "*************\n";
                avgwt = avgwt / pro;
                avgtt = avgtt / pro;
                cout << "Average Waiting Time : " << avgwt << endl;
                cout << "Average Turnaround Time : " << avgtt << endl;
              
            }
            break;

            case 5:
            {
  
            process p[100];

            int i, n, n1, n2, n3, t1;
            int  gantt[20][2];
            cout << "enter no of process : ";
            cin >> n;
            for (i = 0; i < n; i++) {

            cout << "Enter Process ID : ";
            cin >> p[i].process_id;

            cout << "Enter Arrival Time : ";
            cin >> p[i].arrival_time;

             cout << "Enter Burst Time : ";
             cin >> p[i].burst_time;

             }

            int j, k, t, e = 0, m = 0;
             float aw, at, sum1;

             cout << "\n\nP  A  B  W  TAT\n\n";
             for (i = 0;i < n;i++)
            {
             for (j = i + 1;j < n;j++)
             {
              if ((p[i].arrival_time > p[j].arrival_time) || ((p[i].arrival_time == p[j].arrival_time) && (p[i].burst_time > p[j].burst_time)))
            {
            t = p[i].arrival_time;
            p[i].arrival_time = p[j].arrival_time;
            p[j].arrival_time = t;

            t = p[i].burst_time;
            p[i].burst_time = p[j].burst_time;
            p[j].burst_time = t;

            t = p[i].process_id;
            p[i].process_id = p[j].process_id;
            p[j].process_id = t;
           }
        }
    }
            k = p[0].arrival_time + p[0].burst_time;
            for (i = 1;i < n;i++)
          {
            for (j = i + 1;j < n;j++)
             {
          if (p[i].burst_time > p[j].burst_time && k >= p[j].arrival_time)
           {
            m = 1;

            t = p[i].burst_time;
            p[i].burst_time = p[j].burst_time;
            p[j].burst_time = t;

            t = p[i].arrival_time;
            p[i].arrival_time = p[j].arrival_time;
            p[j].arrival_time = t;

            t = p[i].process_id;
            p[i].process_id = p[j].process_id;
            p[j].process_id= t;
        }
    }
    if (m == 0)
        k = k + p[i].burst_time;
    else
        k++;
    m = 0;
}

t1 = 0;
for (i = 0;i < n;i++)
{
    if (t1 - p[i].arrival_time < 0)
    {
        gantt[e][0] = -1;
        gantt[e++][1] = t1;
        t1 += p[i].arrival_time - t1;
    }
    if (i == 0)
        p[i].waiting_time = 0;
    else
        p[i].waiting_time = t1 - p[i].arrival_time;
    gantt[e][0] = p[i].arrival_time;
    gantt[e++][1] = t1;
    t1 += p[i].burst_time;
}
gantt[e][1] = t1;
for (i = 0;i < n;i++)
{
    p[i].turnaround_time = p[i].burst_time + p[i].waiting_time;
}
for (i = 0;i < n;i++)
{
    cout << p[i].process_id<< "  " << p[i].arrival_time << "  " << p[i].burst_time << "  " << p[i].waiting_time << "  " << p[i].turnaround_time << endl;
}
cout << "\nAverage waiting time is:";
sum1 = 0.0;
for (i = 0;i < n;i++)
{
    sum1 += p[i].waiting_time;
}
aw = sum1 / n;
cout << aw;

cout << "\nAverage turn around time is:";
sum1 = 0.0;
for (i = 0;i < n;i++)
{
    sum1 += p[i].turnaround_time;
}
at = sum1 / n;
cout << at;
cout << "\n\nThe Gantt chart is:\n\n";

cout << " ";
for (i = 0;i < e;i++)
    cout << "--- ";
cout << "\n";
for (i = 0;i < e;i++) {

    if (gantt[i][0] == -1) cout << "|  ";
    else cout << "|  " << gantt[i][0] << " ";


}

cout << "|\n ";
for (i = 0;i < e;i++)
    cout << "--- ";
cout << "\n";
for (i = 0;i <= e;i++)
cout << gantt[i][1] << "   ";
            }
            break;
            }
            cout << "\n press 1 to continue and press 2 to exit" << endl;
            cin >> continue_;
            if (continue_ == 2)
            {
                exit(0);
            }
        } while (continue_ == 1);
    }while (1);

}