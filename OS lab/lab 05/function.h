#pragma once

#include <iostream>
#include <cstring>
using namespace std;

class SingleDoubleArray{
public:
char *getSingleArray(char **,const char *, int);
char **getDoubleArray(char *, const char *);

void displaySingleArray(char *);
void displayDoubleArray(char **, int,const char*);

int calcSingleSize(char **,const char *, int);
int calcDoubleSize(char *,const char *);

char** trimDoubleArray(char**,int s,int e);
char* trimSingleArray(char*,int s,int e);

bool isCharSame(const char*,char*,int);

void sortDoubleArray(char**,int);

};

char* SingleDoubleArray::getSingleArray(char **in,const char *enc, int n)
{
    // Calulate Single Array Result Size
    int size = calcSingleSize(in, enc,n);
    // Dynamically Allocate Size
    char *result = nullptr;
    result = new char[size + 1];
    memset(result, 0, size + 1); // set all bytes to zero

    // Converting Double Array into Single Array
    int index = 0;
    for (int i = 0; i < n; i++)
    {
        // Store  Value
        for (int j = 0; j < strlen(in[i]); j++)
        {
            result[index++] = in[i][j];
        }
        // Store Encrypted Value
        for (int j = 0; j < strlen(enc); j++)
        {
            result[index++] = enc[j];
        }
    }
    return result;
}
char** SingleDoubleArray::getDoubleArray(char* arr,const char* enc){
    int e_size = strlen(enc);

    int size = calcDoubleSize(arr,enc);

     char** result = new char* [size];
     int index=0;

    // functions to set Data in Result
    int s=0;
    for(int i=0; i<strlen(arr);i++){
        if(isCharSame(enc,arr,i)){
            // Encrypt Value find  break and store
            result[index++]= trimSingleArray(arr,s,i-1);
            s=i+e_size;
            
        }
    }

     return result;

}

void SingleDoubleArray::displaySingleArray(char* arr){
    cout<<arr<<endl;
}
void SingleDoubleArray::displayDoubleArray(char** arr,int n ,const char* space = "\n"){
    for(int i=0 ;i<n;i++){
        cout<<arr[i]<<space;
    }
    cout<<endl;
}

int SingleDoubleArray::calcSingleSize(char **arr,const char *enc, int n)
{
    int encrSize = strlen(enc);
    int size = 0;
    for (int i = 0; i < n; i++)
    {
        size += strlen(arr[i]);
        size += encrSize;
    }
    return size;
}
int SingleDoubleArray::calcDoubleSize(char *arr, const char *enc)
{
    int size = 0;
    char *word;
    int s_size = strlen(arr);
    int e_size = strlen(enc);
    //Comparing Values from first till last including last variable of encryp
    for (int i = 0; i < s_size - e_size +1;) 
    {
        if (isCharSame(enc, arr, i))
        {   
            // Values matches
            size++;
            i += e_size;
        }
        else
        {
            // values not matches
            i++;
        }
    }
    return size;
}

char* SingleDoubleArray::trimSingleArray(char* arr,int s_index,int e_index){
    int size = e_index-s_index+1;
    char *trimed = nullptr;
    trimed = new char[size + 1];
    memset(trimed, 0, size + 1);

    for(int i=0 ; i<size;i++){
        trimed[i]=arr[s_index+i];
    }
    return trimed;
}
char** SingleDoubleArray::trimDoubleArray(char** arr,int s_index,int e_index){
    int size = e_index-s_index+1;
    char** trimed = new char* [size];

    for(int i=0 ; i<size;i++){
        trimed[i]=arr[s_index+i];
    }
    return trimed;
}

bool SingleDoubleArray::isCharSame(const char *a,char *b, int s)
{
    int a_size = strlen(a);
    bool isSame = true;
    for (int i = 0; i < a_size; i++)
    {
        if (b[s + i] != a[i])
        {
            isSame = false;
            break;
        }
    }
    return isSame;
}

void SingleDoubleArray::sortDoubleArray(char** arr,int n){
       try{
            for (int i = 0; i < n-1; i++) {
                for (int j = 0; j < n-i-1; j++) {
                    // Compare the two char pointers as strings and swap them if they're in the wrong order
                    if (stoi(arr[j])> stoi(arr[j+1])) {
                        char* temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }
        catch(const std::invalid_argument& e) {
                std::cerr << "Error Arguments have non-numerice value"<<endl ;      
        }
}



