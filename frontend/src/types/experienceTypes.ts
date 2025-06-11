export type ChipIconName = "laptop" | "book" | "star";

export type ChipVariant = {
  className: string;
  iconName: ChipIconName;
  text: string
};

export const experienceTypeMap: Record<string, ChipVariant> = {
  "work": {
    className: "cx-chip cx-chip__blue cx-mr-6",
    iconName: "laptop",
    text: "Jobb"
  },
  "education": {
    className: "cx-chip cx-chip__purple cx-mr-6",
    iconName: "book",
    text: "Utdanning"
  },
  "other": {
    className: "cx-chip cx-chip__green cx-mr-6",
    iconName: "star",
    text: "Annet"
  }
};
