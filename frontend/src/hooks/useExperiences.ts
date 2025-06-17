import { useQuery } from '@tanstack/react-query';
import { fetchExperiences } from '../api';
import { Experience } from '../types/types';

export function useExperiences() {
  return useQuery({
    queryKey: ['experiences'],
    queryFn: fetchExperiences,
    select: (data: Experience[]) => data,
  });
}
