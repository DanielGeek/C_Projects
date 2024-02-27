//
//  main.cpp
//  Array_Basics
//
//  Created by Daniel Elías Ángel Barreto on 26/2/24.
//

#include <iostream>

using namespace std;

int main() {
    int n;
    cout << "Enter Size";
    cin >> n;
    int A[n];
    A[0]=2;
    
    for (int x:A) {
        cout << x << endl;
    }

//    int A[10]={2, 4, 6, 8, 10, 12};
//    int A[]={2, 4, 6, 8, 10, 12, 14};
//    int A[5]={2, 4, 6, 8, 10};
//    A[0]=12;
//    A[1]=15;
//    A[2]=25;
//    for (int i=0; i<10; i++) {
//        cout << A[i] << endl;
//    }
//    cout << sizeof(A) << endl;
//    cout << A[2] << endl;
//    printf("%d\n", A[3]);
    
    return 0;
}
