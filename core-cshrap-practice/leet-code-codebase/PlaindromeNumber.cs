class PalindromeNumber {
    public bool IsPalindrome(int n) {
        if(n<0||(n%10==0&&n!=0)){
            return false;
        }
        int reversednumber=0;
        while(n>reversednumber){
            reversednumber=reversednumber*10+n%10;
            n/=10;
        }
        return n==reversednumber||n==reversednumber/10;

    }
}