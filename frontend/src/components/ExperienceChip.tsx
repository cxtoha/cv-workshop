import { CxIcon } from "@computas/designsystem/icon/react";

type ExperienceChipProps = {
  type: string;
};

type ChipIconName = "laptop" | "book" | "star";

type ChipVariant = {
  className: string;
  iconName: ChipIconName;
  text: string
};

export function ExperienceChip({ type }: ExperienceChipProps) {
  const variantMap: Record<string, ChipVariant> = {
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

  const variant = variantMap[type.toLowerCase()] || variantMap.other;

  return (
    <div className={variant.className}>
      <CxIcon name={variant.iconName} size="4" />
      {variant.text}
    </div>
  );
}
