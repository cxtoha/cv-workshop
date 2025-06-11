variable "revision_suffix" {
  description = "Suffix to append to the revision name of the container app. Should normally be git commit hash."
  type        = string
}

variable "repository_owner" {
  description = "GitHub repository owner for the container image."
  type        = string
}

variable "api_key" {
  description = "API key for frontend/backend communication."
  type        = string
  sensitive   = true
}

variable "connection_string" {
  description = "Connection string for the Supabase database."
  type        = string
  sensitive   = true
}
