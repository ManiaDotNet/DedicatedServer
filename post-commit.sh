#!/bin/sh
#Move this to ./git/hooks and remove the .sh
for f in $(git diff-tree --no-commit-id --name-only HEAD)
do
	# Check if a new doc was built (config will have changed)
	if [ "$f" == "DedicatedServer.sdox" ] && [ -d ./doc/Html/default ]
	then
		git checkout gh-pages
		
		# Remove folders, because mv won't overwrite them
		rm -r ./article
		rm -r ./assets
		rm -r ./namespace
		rm -r ./type
		
		# Move directories and files to the root folder
		for f in ./doc/Html/default/*
		do
			mv -f "$f" .
		done
		
		# Remove and recreate doc folder (required by doc builder), but not the rest
		rm -r ./doc
		mkdir ./doc
		
		./FilePatcher.exe index.html before "    </head>" favicon.html
		
		git add --all
		git commit -m "Update Documentation"
		git checkout master
	fi
done