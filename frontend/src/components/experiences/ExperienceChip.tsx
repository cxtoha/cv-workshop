import { CxIcon } from "@computas/designsystem/icon/react";
import { experienceTypeMap } from "../../types/experienceTypes";

type ExperienceChipProps = {
  type: string;
};

export function ExperienceChip({ type }: ExperienceChipProps) {

  const variant = experienceTypeMap[type.toLowerCase()] || experienceTypeMap.other;

  return (
    <div className={variant.className}>
      <CxIcon name={variant.iconName} size="4" />
      {variant.text}
    </div>
  );
}
