﻿// ======================================
// Author: Atif SECGINLI
// Email:  info@intapptech.com
// Copyright (c) 2017 www.intapptech.com
// 
// ==> Gun4Hire: contact@intapptech.com
// ======================================

export type PermissionNames =
    "View Users" | "Manage Users" |
    "View Roles" | "Manage Roles" | "Assign Roles" |
    
    "Viev Questions" | "Manage Questions"

    ;

export type PermissionValues =
    "users.view" | "users.manage" |
    "roles.view" | "roles.manage" | "roles.assign" |

        //* Question Banks *//
        "questions.view" | "questions.manage"
    
    ;

export class Permission {

    public static readonly viewUsersPermission: PermissionValues = "users.view";
    public static readonly manageUsersPermission: PermissionValues = "users.manage";

    public static readonly viewRolesPermission: PermissionValues = "roles.view";
    public static readonly manageRolesPermission: PermissionValues = "roles.manage";
    public static readonly assignRolesPermission: PermissionValues = "roles.assign";

        //* Question Banks *//
        public static readonly viewQuestionsPermission: PermissionValues = "questions.view";
        public static readonly manageQuestionsPermission: PermissionValues = "questions.manage";


    constructor(name?: PermissionNames, value?: PermissionValues, groupName?: string, description?: string) {
        this.name = name;
        this.value = value;
        this.groupName = groupName;
        this.description = description;
    }

    public name: PermissionNames;
    public value: PermissionValues;
    public groupName: string;
    public description: string;
}