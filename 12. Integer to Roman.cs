public class Solution {
    public string IntToRoman(int num) {
        
        
        string answer ="";
        
        while(num!=0){
            if(num>=1000){
                num -= 1000;
                answer+= "M";
            }
            else if(num>=900){
                num -= 900;
                answer+= "CM";
            }
            else if(num>=500){
                num -= 500;
                answer+= "D";
            }
            else if(num>=400){
                num -= 400;
                answer+= "CD";
            }
            else if(num>=100){
                num -= 100;
                answer+= "C";
            }
            else if(num>=90){
                num -= 90;
                answer+= "XC";
            }
            else if(num>=50){
                num -= 50;
                answer+= "L";
            }
            else if(num>=40){
                num -= 40;
                answer+= "XL";
            }
            else if(num>=10){
                num -= 10;
                answer+= "X";
            }
            else if(num>=9){
                num -= 9;
                answer+= "IX";
            }
            else if(num>=5){
                num -= 5;
                answer+= "V";
            }
            else if(num>=4){
                num -= 4;
                answer+= "IV";
            }
            else{
                num -= 1;
                answer+= "I";
            }
        }
        return answer;
    }
}