#!/bin/bash
USER_ID=${LOCAL_USER_ID:-9001}

echo "Starting with UID : $USER_ID"
useradd --shell /bin/bash -u $USER_ID -o -c "" -m user
export HOME=/home/user

GOSU="/bin/gosu user"

echo "Making sure the current user owns the source files"
chown -R $USER_ID:$USER_ID /code
chown -R $USER_ID:$USER_ID /home/user/

echo "Making sure extensions are installed for the current user"
/bin/gosu user /usr/bin/code --install-extension ms-vscode.csharp

echo "Running: $GOSU $@"
exec /bin/gosu user /usr/bin/code --wait