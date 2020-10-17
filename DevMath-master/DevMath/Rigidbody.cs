﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        }

        public float mass = 1.0f;
        public float force = 150.0f;
        public float dragCoefficient = .47f;

        public void AddForce(Vector2 forceDirection, float deltaTime)
        {
			Vector2 _vector2 = forceDirection * this.force / this.mass * deltaTime;

			this.Velocity = new Vector2()
			{
				x = (float)((1.0 / dragCoefficient) * Math.Exp(-dragCoefficient / mass * deltaTime) * ((dragCoefficient * Velocity.x) + (mass * _vector2.x)) 
				- (mass * _vector2.x) / dragCoefficient),
				y = (float)((1.0 / dragCoefficient) * Math.Exp(-dragCoefficient / mass * deltaTime) * ((dragCoefficient * Velocity.y)
				+ (mass * _vector2.y)) - (mass * _vector2.y) / dragCoefficient)
			};

			//throw new NotImplementedException();
		}
    }
}
