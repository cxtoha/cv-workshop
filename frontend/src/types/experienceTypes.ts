export type ChipIconName = "laptop" | "book" | "chess" | "soccer" | "beer";

export type ChipVariant = {
  className: string;
  iconName: ChipIconName;
  text: string
};

export const experienceTypeMap: Record<string, ChipVariant> = {
  work: {
    className: "cx-chip cx-chip__blue cx-mr-6",
    iconName: "laptop",
    text: "Jobb",
  },
  education: {
    className: "cx-chip cx-chip__purple cx-mr-6",
    iconName: "book",
    text: "Utdanning",
  },

  voluntary: {
    className: "cx-chip cx-chip__green cx-mr-6",
    iconName: "chess",
    text: "Verv",
  },
  hobbyproject: {
    className: "cx-chip cx-chip__red cx-mr-6",
    iconName: "beer",
    text: "Hobbyprosjekt",
  },
  other: {
    className: "cx-chip cx-chip__yellow cx-mr-6",
    iconName: "soccer",
    text: "Annet",
  },
};
