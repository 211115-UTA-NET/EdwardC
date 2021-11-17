#!/usr/bin/bash

#Create a new folder
mkdir ./test

#Create a new file in that folder
touch ./test/newtext.txt

#Write text to the new file
echo "new line here" > ./test/newtext.txt

#For loop 1-20, append odd to file
for i in {1..20..2}
do
echo "$i" >> ./test/newtext.txt
done

#Loop 1-20, print even numbers to a single line
#for (( i=2; i<=20; i+= ));
#do
#   if [ $i -lt 20 ]; then
#      echo -n "$i, "
#   else
#      echo -n $i
#   fi
#done

for i in {2..20..2}
do
  nums+=$i
  if (( $i<20 ))
  then
     nums+=", "
  fi
done

echo $nums >> ./test/newtext.txt