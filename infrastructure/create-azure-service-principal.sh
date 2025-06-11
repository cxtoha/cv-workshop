#!/bin/bash

main() {
    # Get subscription ID
    local subscription_id
    subscription_id=$(az account show --query id -o tsv)
    
    # Create a service principal with Contributor role
    local service_principal
    service_principal=$(az ad sp create-for-rbac --role="Contributor" --scopes="/subscriptions/$subscription_id" --name "terraform")

    echo "ARM_CLIENT_ID=$(echo "$service_principal" | jq -r '.appId')"
    echo "ARM_CLIENT_SECRET=$(echo "$service_principal" | jq -r '.password')"
    echo "ARM_SUBSCRIPTION_ID=$subscription_id"
    echo "ARM_TENANT_ID=$(echo "$service_principal" | jq -r '.tenant')"
}

main "$@"
