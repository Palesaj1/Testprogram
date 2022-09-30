class ls
{
    public static void MainPalesa (string[] args)
    {
        int[] element = {45,87,30,20,97,63,75,34,88};
    int item =75;
    int noe = element.Length;
    int flag= -1;
    
    for(int i=0;i<noe;i++)
    {
        if(element[i]==item)
        {
            Console.WriteLine("The item" + item + "is found in position " + (i+1));
            flag= -1;
        }
       else
         flag = 100;
    }
     if(flag== 100)
        Console.WriteLine("The item " + item + " is NOT found.");
       
        

    }
}
