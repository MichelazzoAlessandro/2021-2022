import { question } from "readline-sync";
function main (){
    var arrfinale = new Array;
    var arrbase = new Array;
    var n = question("Quanti numeri vuoi inserire? ");
    
    for(var i = 0; i<n; i++){
        var numbers = question(i +'°' + " numero ");
        arrbase[i] = numbers;
    }
    

    for(let i = 0; i < arrbase.length ; i++)
       {
           for(let j = 0; j < arrbase.length - i - 1; j++)
           {
               if(arrbase[j] > arrbase[j + 1])
               {
                   arrfinale[i] = arrbase[j];

               }
           }
       }
    console.log(arrfinale);
}
main();
