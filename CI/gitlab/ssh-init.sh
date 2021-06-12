# only run in docker:
[[ ! -e /.dockerenv ]] && exit 0

mkdir -p ~/.ssh
echo "$GITLAB_RUNNER_SSH_KEY" > ~/.ssh/id_rsa
chmod 400 ~/.ssh/id_rsa
echo -e "Host *\n\tStrictHostKeyChecking no\n\n" > ~/.ssh/config