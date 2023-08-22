class Solution {
public:
    string convertToTitle(int columnNumber) {
        string s="";
        int i=0;
        do{
            i=columnNumber/26;
            columnNumber%=26;
            if(i>0 &&columnNumber==0){
                s="Z"+s; 
                i--;
            }else{
                s=getLetter(columnNumber)+s;  
            }
            columnNumber=i;
            cout<<"i="<<i<<endl<<"c"<<columnNumber<<endl;
        }while(i!=0);
        return s;
    }
    inline char getLetter(int x){
        char A=64+x;
        return A;
    }
};