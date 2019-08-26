//
//  MyClass.swift
//  NewSampleBInding
//
//  Created by BridgeLabz on 26/08/19.
//  Copyright © 2019 BridgeLabz. All rights reserved.
//

import UIKit

@objc(MyClass)
open class MyClass: NSObject {
    
    @objc func Test() -> String
    {
        return "Value came from swift";
    }
}
