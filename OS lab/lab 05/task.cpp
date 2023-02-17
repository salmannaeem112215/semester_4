#include<iostream>
#include<string>
#include <unistd.h>
#include <stdlib.h>
#include "function.h"
using namespace std;

const char* ENCR = "@@@";


int main(int n,char** arg){

    int dp;
    int fd1[2];
    int fd2[2];
    pid_t pid;
    SingleDoubleArray SDA;


    // Created Buffer and setting its value to \0
    char* buffer = new char[BUFSIZ +1];
    memset(buffer,'\0',BUFSIZ +1);

    // Creating Pipes
    if(pipe(fd1)!=0) exit(0);
    if(pipe(fd2)!=0) exit(0);

    // Creating CHild Process    
    pid=fork();

    if(pid==0){
        // Child Process Block

        // 1. Reading Unsorted Single Arr with ENcryption
        dp =  read(fd1[0],buffer,BUFSIZ+1);
        // cout<<"DP "<<dp <<"Parent Buffer Read"<<buffer<<endl;

        // 2. Converting into Double Array 
        char** arr = SDA.getDoubleArray(buffer,ENCR);
        int d_size = SDA.calcDoubleSize(buffer,ENCR);

        // 3. Sorting DOuble Array  of Char
        SDA.sortDoubleArray(arr,d_size);        

        // 4. COnverting into SIngle Array With Encryption
        char* s_arr = SDA.getSingleArray(arr,ENCR,d_size);

        // 5. Sending Sorted SIngle array to Parent
        dp = write(fd2[1],s_arr,strlen(s_arr));
        // cout<<"DP "<<dp <<" CHild Message Write "<<s_arr<<endl;

    }
    else if(pid>0){
        //Parent Process Block

        //1.  Removing First Argument
        char** arr = SDA.trimDoubleArray(arg,1,n+1);
        //2.  Converting into Single Arr
        char* s_arr = SDA.getSingleArray(arr,ENCR,n-1);

        //3.  Sending Single Array to Pipe
        dp = write(fd1[1],s_arr,strlen(s_arr));
        // cout<<"DP "<<dp <<"Parent  Message Write "<<s_arr<<endl;

        //4. Reciving Sorted Single Array from pipe
        dp = read(fd2[0],buffer,BUFSIZ +1);
        // cout<<"DP "<<dp <<" Parent Message Read"<<buffer<<endl;

        // 5. Converting back to Double 
        arr = SDA.getDoubleArray(buffer,ENCR);
        SDA.displayDoubleArray(arr,SDA.calcDoubleSize(buffer,ENCR)," ");



    }
 
    return 0;
}
