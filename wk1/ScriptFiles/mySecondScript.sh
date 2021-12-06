#!/usr/bin/bash

#Prompt the user
echo "Enter the filename you would like to add"
echo "Include the file extension"

#accept user input
read fileName

#Filter only .txt, .md, .sh, .png files

#save the extention abreviation as ext
ext="${fileName##*.}"

if (( $ext == "txt" || $ext == "md" || $ext == "sh" || $ext == "png" ))
then

	#add the entered file to staging
	git add $fileName

	#Prompt user for commit messgae
	echo "Please enter the commit message"

	#Accept user input
	read message

	#commit the staged files
	git commit -m "$message"

	#push the commit
	git push
else
	echo "that file will not be accepted"
fi

