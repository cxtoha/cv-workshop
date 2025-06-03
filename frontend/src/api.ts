import { User, Experience } from "./types";

const API_URL = import.meta.env.VITE_API_URL as string;
const API_KEY = import.meta.env.VITE_API_KEY as string;

async function authorizedFetch(path: string): Promise<Response> {
    const res = await fetch(`${API_URL}${path}`, {
        headers: {
            "X-Frontend-Api-Key": API_KEY,
            "Content-Type": "application/json",
        },
    });
    if (!res.ok) {
        throw new Error(`API request failed (${res.status}): ${res.statusText}`);
    }
    return res;
}

export async function fetchUsers(): Promise<User[]> {
    const res = await authorizedFetch("/users");
    return res.json();
}

export async function fetchExperiences(): Promise<Experience[]> {
    const res = await authorizedFetch("/experiences");
    return res.json();
}

// (You can also keep fetchUserById, fetchExperienceById, fetchExperiencesForUser, etc.)
