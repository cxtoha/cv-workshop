"use client";

import React, { ReactNode } from "react";
import classes from "./nav-link.module.css";

type NavLinkProps = { href: string; children: ReactNode };

export default function NavLink({ href, children }: NavLinkProps) {
  
  return (
    <a className={classes.link} href={href}>
      {children}
    </a>
  );
}
